using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Course
{
    public partial class Database : Form
    {
        /* Форма Database доступна администратору из Admin_input.
           В ней администратору будет доступна информация про всех зарегистрированных
           пользователях, а также об их складах. Администратору будет доступна форма удаления
           склада пользователей, однако данная функция будет не доступна пока хоть один из пользователей
           не создаст в первый раз свой склад. Также администратор может сохранить все данные в бинарный файл,
           что-бы, например, в случае перезагрузки системы, загрузить их обратно в массивы данных. */

        public Database()
        {
            InitializeComponent();
        }

        private void Database_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            int count = 0;

            try
            {
                for (int i = 0; i < Input_Reg.size; i++)
                {
                    richTextBox1.Text += ($"Пользователь номер {i + 1}:\n");
                    richTextBox1.Text += ($"Имя: {Input_Reg.name[i]}\n");
                    richTextBox1.Text += ($"Фамилия: {Input_Reg.surname[i]}\n");
                    richTextBox1.Text += ($"Пароль: {Input_Reg.password[i]}\n\n");

                    if (Functional.size > 0)
                    {
                        if (Functional.size == Input_Reg.size)
                        {
                            if (Functional.product_name[i] != null)
                            {
                                richTextBox2.Text += ($"Склад пользователя номер {i + 1}:\n");
                                richTextBox2.Text += ($"Номер склада: {Functional.number_of_warehouse[i]}\n");
                                richTextBox2.Text += ($"Название товара: {Functional.product_name[i]}\n");
                                richTextBox2.Text += ($"Фирма: {Functional.firm[i]}\n");
                                richTextBox2.Text += ($"Цена за ед.: {Functional.price[i]}\n");
                                richTextBox2.Text += ($"Кол-во: {Functional.quantity[i]}\n");
                                richTextBox2.Text += ($"Мин. партия: {Functional.min_party[i]}\n\n");
                            }
                            else
                            {
                                richTextBox2.Text += ($"У пользователя с именем {Input_Reg.name[i]} нет своего склада\n\n");
                            }
                        }
                        else
                        {
                            if (count == 0)
                            {                                
                                for (int j = 0; j < Functional.size; j++)
                                {
                                    if (Functional.product_name[j] != null)
                                    {
                                        richTextBox2.Text += ($"Склад пользователя номер {j + 1}:\n");
                                        richTextBox2.Text += ($"Номер склада: {Functional.number_of_warehouse[j]}\n");
                                        richTextBox2.Text += ($"Название товара: {Functional.product_name[j]}\n");
                                        richTextBox2.Text += ($"Фирма: {Functional.firm[j]}\n");
                                        richTextBox2.Text += ($"Цена за ед.: {Functional.price[j]}\n");
                                        richTextBox2.Text += ($"Кол-во: {Functional.quantity[j]}\n");
                                        richTextBox2.Text += ($"Мин. партия: {Functional.min_party[j]}\n\n");
                                    }
                                    else
                                    {
                                        richTextBox2.Text += ($"У пользователя номер {j + 1} нет своего склада\n\n");
                                    }

                                    count++;
                                }
                                if (count == Functional.size)
                                {
                                    for (int j = Functional.size; j < Input_Reg.size; j++)
                                    {
                                        richTextBox2.Text += ($"У пользователя номер {j + 1} никогда не было своего склада\n\n");
                                        count++;
                                    }
                                }
                            }                          
                        }
                    }
                    else
                    {
                        richTextBox2.Text += ("Не один пользователь еще не разу не создал свой склад\n\n");
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_welcome admin_welcome = new Admin_welcome();
            admin_welcome.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Functional.size > 0)
            {
                Admin_delete_warehouse admin_delete_warehouse = new Admin_delete_warehouse();
                admin_delete_warehouse.Show();
            }
            else
            {
                MessageBox.Show("Не один из пользователей еще не разу не создавал свой склад для его удаления");
            }
        }

        private void Database_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Admin_reference admin_Reference = new Admin_reference();
            admin_Reference.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "Binary file (*.bin) | *.bin";

            try
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string file_name = save.FileName;
                    FileStream file = new FileStream(file_name, FileMode.OpenOrCreate, FileAccess.Write);
                    BinaryWriter bin_wr = new BinaryWriter(file, Encoding.UTF8);

                    bin_wr.Write(Functional.size);

                    for (int i = 0; i < Functional.size; i++)
                    {
                        if (Functional.product_name[i] != null)
                        {
                            bin_wr.Write(Functional.product_name[i]);
                            bin_wr.Write(Functional.firm[i]);
                            bin_wr.Write(Functional.price[i]);
                            bin_wr.Write(Functional.quantity[i]);
                            bin_wr.Write(Functional.number_of_warehouse[i]);
                            bin_wr.Write(Functional.min_party[i]);
                        }
                    }

                    MessageBox.Show("Данные о складах были успешно сохранены");
                    bin_wr.Close();
                    file.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Binary file (*.bin) | *.bin";

            try
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    var Yes = MessageBox.Show("Вы уверены? Старые записи о складах будут удалены.", " ", MessageBoxButtons.YesNo);
                    if (Yes == DialogResult.Yes)
                    {
                        string filename = open.FileName;
                        FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read);
                        BinaryReader bin_wr = new BinaryReader(file, Encoding.UTF8);

                        Functional.size = bin_wr.ReadInt32();

                        Array.Resize(ref Functional.product_name, Functional.size);
                        Array.Resize(ref Functional.firm, Functional.size);
                        Array.Resize(ref Functional.price, Functional.size);
                        Array.Resize(ref Functional.quantity, Functional.size);
                        Array.Resize(ref Functional.number_of_warehouse, Functional.size);
                        Array.Resize(ref Functional.min_party, Functional.size);

                        for (int i = 0; i < Functional.size; i++)
                        {
                            Functional.product_name[i] = bin_wr.ReadString();
                            Functional.firm[i] = bin_wr.ReadString();
                            Functional.price[i] = bin_wr.ReadInt32();
                            Functional.quantity[i] = bin_wr.ReadInt32();
                            Functional.number_of_warehouse[i] = bin_wr.ReadInt32();
                            Functional.min_party[i] = bin_wr.ReadInt32();

                            if (Functional.product_name[i] != null)
                            {
                                richTextBox2.Text += ($"Склад пользователя номер {i + 1}:\n");
                                richTextBox2.Text += ($"Номер склада: {Functional.number_of_warehouse[i]}\n");
                                richTextBox2.Text += ($"Название товара: {Functional.product_name[i]}\n");
                                richTextBox2.Text += ($"Фирма: {Functional.firm[i]}\n");
                                richTextBox2.Text += ($"Цена за ед.: {Functional.price[i]}\n");
                                richTextBox2.Text += ($"Кол-во: {Functional.quantity[i]}\n");
                                richTextBox2.Text += ($"Мин. партия: {Functional.min_party[i]}\n\n");
                            }
                            else
                            {
                                Array.Clear(Functional.product_name, i, 1);
                                Array.Clear(Functional.firm, i, 1);
                                Array.Clear(Functional.price, i, 1);
                                Array.Clear(Functional.quantity, i, 1);
                                Array.Clear(Functional.number_of_warehouse, i, 1);
                                Array.Clear(Functional.min_party, i, 1);

                                richTextBox2.Text += ($"У пользователя номер {i + 1} нет своего склада\n\n");
                            }
                        }

                        MessageBox.Show("Данные о складах были успешно загружены");
                        bin_wr.Close();
                        file.Close();

                        if (Functional.index >= Functional.size)
                        {
                            Functional.index = Functional.size - 1;
                        }
                    }
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "Binary file (*.bin) | *.bin";

            try
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string file_name = save.FileName;
                    FileStream file = new FileStream(file_name, FileMode.OpenOrCreate, FileAccess.Write);
                    BinaryWriter bin_wr = new BinaryWriter(file, Encoding.UTF8);
                    bin_wr.Write(Input_Reg.size);

                    for (int i = 0; i < Input_Reg.size; i++)
                    {
                        bin_wr.Write(Input_Reg.name[i]);
                        bin_wr.Write(Input_Reg.surname[i]);
                        bin_wr.Write(Input_Reg.password[i]);
                    }

                    MessageBox.Show("Данные о пользователях были успешно сохранены");
                    bin_wr.Close();
                    file.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Binary file (*.bin) | *.bin";

            try
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    var Yes = MessageBox.Show("Вы уверены? Старые записи о пользователях будут удалены.", " ", MessageBoxButtons.YesNo);
                    if (Yes == DialogResult.Yes)
                    {
                        string filename = open.FileName;
                        FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read);
                        BinaryReader bin_wr = new BinaryReader(file, Encoding.UTF8);

                        Input_Reg.size = bin_wr.ReadInt32();

                        Array.Resize(ref Input_Reg.name, Input_Reg.size);
                        Array.Resize(ref Input_Reg.surname, Input_Reg.size);
                        Array.Resize(ref Input_Reg.password, Input_Reg.size);

                        for (int i = 0; i < Input_Reg.size; i++)
                        {
                            Input_Reg.name[i] = bin_wr.ReadString();
                            Input_Reg.surname[i] = bin_wr.ReadString();
                            Input_Reg.password[i] = bin_wr.ReadString();

                            richTextBox1.Text += ($"Пользователь номер {i + 1}:\n");
                            richTextBox1.Text += ($"Имя: {Input_Reg.name[i]}\n");
                            richTextBox1.Text += ($"Фамилия: {Input_Reg.surname[i]}\n");
                            richTextBox1.Text += ($"Пароль: {Input_Reg.password[i]}\n\n");
                        }

                        MessageBox.Show("Данные о пользователях были успешно загружены");
                        bin_wr.Close();
                        file.Close();

                        if (Input_Reg.index >= Input_Reg.size)
                        {
                            Input_Reg.index = Input_Reg.size - 1;
                        }
                    }
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }
    }
}

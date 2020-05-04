using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    public partial class Database : Form
    {
        /* Форма Database доступна администратору из Admin_input.
           В ней администратору будет доступна информация про всех зарегистрированных
           пользователях, а также об их складах. Администратору будет доступна форма удаления
           склада пользователей, однако данная функция будет не доступна пока хоть один из пользователей
           не создаст в первый раз свой склад. */

        public Database()
        {
            InitializeComponent();
        }

        private void Database_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            for(int i = 0; i < Input_Reg.size; i++)
            {
                richTextBox1.Text += ($"Пользователь номер {i + 1}:\n");
                richTextBox1.Text += ($"Имя: {Input_Reg.name[i]}\n");
                richTextBox1.Text += ($"Фамилия: {Input_Reg.surname[i]}\n");
                richTextBox1.Text += ($"Пароль: {Input_Reg.password[i]}\n\n");

                if (Functional.size > 0)
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
                    richTextBox2.Text += ("Не один пользователь еще не разу не создал свой склад\n\n");
                }
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
    }
}

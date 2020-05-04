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
    public partial class Search_warehouse : Form
    {
        /* Форма Search_warehouse является неким поисковиком сайта.
           Здесь пользователь может вывести прайс лист всех товаров,
           вывести список товаров с минимальной партией 100, а также
           найти необходимый товар по номеру склада в котором он храниться.
           В данную форму можно попасть из формы Welcome. */

        public Search_warehouse()
        {
            InitializeComponent();
        }

        private void Search_warehouse_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            MessageBox.Show("Добро пожаловать на страницу поиска! Тут вы можете найти необходимый товар по номеру склада, в котором он храниться");

            int count = 0;
            for(int i = 0; i < Functional.size; i++)
            {
                if(Functional.number_of_warehouse[i] > 0)
                {
                    count++;
                    if(count == 1)
                    {
                        richTextBox1.Text += ("Доступные склады: ");
                    }
                    richTextBox1.Text += ($"{Functional.number_of_warehouse[i]}; ");
                }
            }
            if(count == 0)
            {
                richTextBox1.Text = ($"На данный момент нет доступных складов, загляните позже");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = new Welcome();
            welcome.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number, count = 0;
            try
            {
                number = Convert.ToInt32(textBox1.Text);
                if(number > 0)
                {
                    for(int i = 0; i < Functional.size; i++)
                    {
                        if(Functional.number_of_warehouse[i] == number)
                        {
                            count++;
                            richTextBox2.Text += ($"Товар склада: {Functional.product_name[i]} \n");
                            richTextBox2.Text += ($"Количество: {Functional.quantity[i]} \n\n");
                        }
                    }
                    if(count == 0)
                    {
                        richTextBox2.Text += ("Склада с таким номером не существует, введите заного\n\n");
                    }
                }
                else
                {
                    MessageBox.Show("Некорректно введенный номер, введите заного");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = 0;
            for(int i = 0; i < Functional.size; i++)
            {
                if(Functional.min_party[i] >= 100)
                {
                    count++;
                    richTextBox2.Text += ($"Товар: {Functional.product_name[i]}\n");
                    richTextBox2.Text += ($"Номер склада: {Functional.number_of_warehouse[i]}\n\n");
                }
            }
            if(count == 0)
            {
                richTextBox2.Text += ("Нет товаров с мин. партией от 100 и больше, загляните позже\n\n");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;
            for(int i = 0; i < Functional.size; i++)
            {
                if(Functional.price[i] > 0)
                {
                    count++;
                    richTextBox3.Text += ($"Товар: {Functional.product_name[i]}\n");
                    richTextBox3.Text += ($"Цена за ед.: {Functional.price[i]}\n\n");
                }
            }
            if (count == 0)
            {
                richTextBox3.Text += ("На данный момент нет доступных товаров, загляните позже\n\n");
            }
        }
    }
}

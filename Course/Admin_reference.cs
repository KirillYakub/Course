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
    /*Справка для администратора о специальных функциях,
      доступные соответственно только администратору.
      Может быть открыта из административных форм нажатием F1. */

    public partial class Admin_reference : Form
    {
        public Admin_reference()
        {
            InitializeComponent();
        }

        private void Admin_reference_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            richTextBox1.Text = "На данной странице администратору доступны вкладки Edit Password и Database.";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            richTextBox1.Text = "На данной странице администратору доступна функция изменения специального пароля. Для этого необходимо ввести старый пароль и два раза новый.";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            richTextBox1.Text = "На данной странице администратору доступна вся информация о пользователях. Также администратор может перейти на вкладку Admin Delete Warehouse.";
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            richTextBox1.Text = "На данной странице администратору доступна функция удаления склада. Для этого необходимо ввести номер склада и пароль от аккаунта.";
        }
    }
}

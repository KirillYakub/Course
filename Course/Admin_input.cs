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
    public partial class Admin_input : Form
    {
        /* В форму Admin_input пользователь сможет попасть из Welcome.
           Для входа от лица администратора пользователю необходимо будет знать пароль,
           изначально введенный и хранящийся в текстовом файле. Предполагается, что
           если пользователь действительно является администратором, то пароль будет
           передан ему разработчиком либо другим администратором. */

        public Admin_input()
        {
            InitializeComponent();
        }

        private void Admin_input_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            MessageBox.Show("Последующие функции сайта доступны только для администратора. Если вы действительно являетесь администратором - введите пароль, хранящийся в специальном файле");
        }

        private void Admin_password(object sender, EventArgs e)
        {
            string password, true_password;
            password = textBox1.Text;
            try 
            {
                true_password = File.ReadAllText(@"C:\Users\KIRILL\source\repos\Course\Admin_password.txt");
                if(password == true_password)
                {
                    this.Hide();
                    Admin_welcome admin_welcome = new Admin_welcome();
                    admin_welcome.Show();
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают, попробуйте еще раз");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Путь к файлу изменен или файл не существует");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = new Welcome();
            welcome.Show();
        }

        private void Admin_input_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Reference reference = new Reference();
            reference.Show();
        }
    }
}

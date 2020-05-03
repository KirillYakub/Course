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
        public Admin_input()
        {
            InitializeComponent();
        }

        private void Admin_input_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            MessageBox.Show("Последующие функции сайта доступны только для администратора. Если вы действительно являетесь администратором - введите пароль, хранящийся в специальном файле");
        }

        private void Save_name_Click(object sender, EventArgs e)
        {
            string password, true_password;
            password = textBox1.Text;
            if(File.Exists(@"C:\Users\KIRILL\source\repos\Course\Admin_password.txt") == true)
            {
                true_password = File.ReadAllText(@"C:\Users\KIRILL\source\repos\Course\Admin_password.txt");
                if(password == true_password)
                {

                }
                else
                {
                    MessageBox.Show("Пароли не совпадают, попробуйте еще раз");
                }
            }
            else
            {
                MessageBox.Show("Путь к файлу изменен или файл не существует");
            }
        }
    }
}

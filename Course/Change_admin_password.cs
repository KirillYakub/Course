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
    public partial class Change_admin_password : Form
    {
        /* Форма Change_admin_password доступна для администратора из Admin_welcome.
           В ней администратор может изменить пароль для входа от лица администратора.
           Для этого ему необходимо ввести старый пароль, а также два раза новый пароль
           для его подтверждения. Длина пароля должна быть минимум три символа. 
           После корректного ввода пароль будет перезаписан в текстовом файле. */

        public Change_admin_password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string old_password, new_password, repeat_new_password;
            
            try
            {
                old_password = textBox1.Text;
                new_password = textBox2.Text;
                repeat_new_password = textBox3.Text;
                if(old_password != new_password && new_password == repeat_new_password && new_password.Length >= 3 && old_password == File.ReadAllText(@"C:\Users\KIRILL\source\repos\Course\Admin_password.txt"))
                {
                    File.WriteAllText(@"C:\Users\KIRILL\source\repos\Course\Admin_password.txt", new_password);
                    MessageBox.Show("Пароль успешно изменен");
                }
                else
                {
                    MessageBox.Show("Проверьте корректность ввода");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Change_admin_password_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_welcome admin_welcome = new Admin_welcome();
            admin_welcome.Show();
        }
    }
}

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
    public partial class Admin_welcome : Form
    {
        /* В форму Admin_welcome может попасть только администратор сайта после
           ввода пароля в Admin_input. Администратор имеет воозможноть изменить пароль для входа
           от лица администратора, вернуться в форму Welcome, а также посмотреть базу данных. */

        public Admin_welcome()
        {
            InitializeComponent();
        }

        private void Admin_welcome_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            try
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\KIRILL\source\repos\Course\Pictures\Admin.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
                label2.Text = ("Изображение не найдено");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = new Welcome();
            welcome.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Change_admin_password change_admin_passsword = new Change_admin_password();
            change_admin_passsword.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Database database = new Database();
            database.Show();
        }
    }
}

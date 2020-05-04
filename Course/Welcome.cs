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
    public partial class Welcome : Form
    {
        /* Welcome - основная форма программы. Здесь
           пользователю будут предложены практически все
           функции сайта. При загрузке форма будет приветствовать
           пользователя по имени, которое будет распознано формой
           по глобальному индексу, а также будет загружено изображение.
           У пользователя будет возможность создать свой склад,
           найти необходимый склад, вернуться на страницу входа или регистрации,
           а также зайти от лица администратора при наличии спец. пароля. */

        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            label2.Text = ($"{Input_Reg.name[Input_Reg.index]} !");
            try
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\KIRILL\source\repos\Course\Pictures\Warehouse.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch(Exception)
            {
                label4.Text = ("Изображение не найдено");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration_form registration_form = new Registration_form();
            registration_form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Input_form input_form = new Input_form();
            input_form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_warehouse new_warehouse = new New_warehouse();
            new_warehouse.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search_warehouse search_warehouse = new Search_warehouse();
            search_warehouse.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_input admin_input = new Admin_input();
            admin_input.Show();
        }
    }
}

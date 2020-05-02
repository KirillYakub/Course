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
    public partial class Input_form : Form
    {
        public Input_form()
        {
            InitializeComponent();
        }

        private void Input_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Title title = new Title();
            title.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            string name, surname, password;
            name = textBox1.Text;
            surname = textBox2.Text;
            password = textBox3.Text;
            for (int i = 0; i < Input_Reg.size; i++)
            {
                if (name == Input_Reg.name[i] && surname == Input_Reg.surname[i] && password == Input_Reg.password[i])
                {
                    count++;
                    this.Hide();
                    Welcome welcome = new Welcome();
                    welcome.Show();
                    break;
                }
            }
            if(count == 0)
            {
                MessageBox.Show("Человека с такими данными не найдено, проверьте корректность ввода");
            }
        }
    }
}

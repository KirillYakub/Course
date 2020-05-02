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
    public partial class Registration_form : Form
    {      
        public Registration_form()
        {
            InitializeComponent();
        }

        private void Registration_form_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { }

        private void textBox2_TextChanged(object sender, EventArgs e)
        { }

        private void Save_name_Click(object sender, EventArgs e)
        {
            string name, surname, password;
            name = textBox1.Text;
            surname = textBox2.Text;
            password = textBox3.Text;
            if(name.Length >= 3 && surname.Length >= 3 && password.Length >= 3)
            {
                Input_Reg.size++;
                Array.Resize(ref Input_Reg.name, Input_Reg.size + 1);
                Array.Resize(ref Input_Reg.surname, Input_Reg.size + 1);
                Array.Resize(ref Input_Reg.password, Input_Reg.size + 1);
                for (int i = Input_Reg.size - 1; i < Input_Reg.size; i++)
                {
                    Input_Reg.name[i] = name;
                    Input_Reg.surname[i] = surname;
                    Input_Reg.password[i] = password;
                }
                this.Hide();
                Welcome welcome = new Welcome();
                welcome.Show();
                
                /*
                richTextBox1.Text += ("Ваши данные и номер регистрации:\n\n");
                for(int i = 0; i < Input_Reg.size; i++)
                {
                    richTextBox1.Text += i + 1;
                    richTextBox1.Text += ($": {Input_Reg.name[i]}");
                    richTextBox1.Text += ($", {Input_Reg.surname[i]}");
                    richTextBox1.Text += ($", {Input_Reg.password[i]}\n\n");
                }
                */
            }
            else
            {
                MessageBox.Show("Все данные не могут состоять менее чем из 3 символов");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Title title = new Title();
            title.Show();
        }
    }
}

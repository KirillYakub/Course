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
        /* Форма Registration_form - форма регистрации пользователя.
           В нее можно попасть из формы Title и Welcome.
           Новому пользователю будет необходимо внести свое имя, фамилию и пароль
           для регистрации. Каждый из пунктов должен быть длинной более трех
           символов, в противном случае будет выдано сообщение о некорректности.
           Если данные заполнены корректно - индекс пользователя запоминается
           в глобальную переменную index, при помощи которой пользователь 
           будет в дальнейшем взаимодействовать с сайтом под своим номером.
           После нажатия кнопки "Зарегистрироваться" массивы паролей, имен и фамилий будут
           увеличены на одну ячейку. */

        public Registration_form()
        {
            InitializeComponent();
        }

        private void Registration_form_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
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
                Array.Resize(ref Input_Reg.name, Input_Reg.size);
                Array.Resize(ref Input_Reg.surname, Input_Reg.size);
                Array.Resize(ref Input_Reg.password, Input_Reg.size);

                for (int i = Input_Reg.size - 1; i < Input_Reg.size; i++)
                {
                    Input_Reg.name[i] = name;
                    Input_Reg.surname[i] = surname;
                    Input_Reg.password[i] = password;
                    Input_Reg.index = i;
                }

                this.Hide();
                Welcome welcome = new Welcome();
                welcome.Show();
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

        private void Registration_form_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Reference reference = new Reference();
            reference.Show();
        }
    }
}

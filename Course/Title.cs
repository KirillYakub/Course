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
    /* Это форма Title. Здесь пользователь имеет возможность
       войти в свой аккаунт или зарегистрироваться если аккаунта нет.
       Также пользователь может заполнить массивы 20-ю записями для дальнейшей
       работы с ними. */

    public partial class Title : Form
    {
        public Title()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            if(Input_Reg.first_input == 0)
            {
                Input_Reg.first_input++;
                var Yes = MessageBox.Show("Хотите заполнить базу данных 20-ю изначальными записями?", " ", MessageBoxButtons.YesNo);
                if (Yes == DialogResult.Yes)
                {                   
                    Input_Reg.size = 20;
                    Functional.size = 20;
                    int letter;

                    Random random = new Random();
                    char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

                    Array.Resize(ref Functional.product_name, Functional.size);
                    Array.Resize(ref Functional.firm, Functional.size);
                    Array.Resize(ref Functional.price, Functional.size);
                    Array.Resize(ref Functional.quantity, Functional.size);
                    Array.Resize(ref Functional.number_of_warehouse, Functional.size);
                    Array.Resize(ref Functional.min_party, Functional.size);

                    Array.Resize(ref Input_Reg.name, Input_Reg.size);
                    Array.Resize(ref Input_Reg.surname, Input_Reg.size);
                    Array.Resize(ref Input_Reg.password, Input_Reg.size);

                    for (int i = 0; i < Input_Reg.size; i++)
                    {
                        Functional.price[i] = random.Next(50, 5000);
                        Functional.quantity[i] = random.Next(20, 2000);
                        Functional.number_of_warehouse[i] = i + 1;
                        Functional.min_party[i] = random.Next(5, 200);

                        for (int j = 0; j < 3; j++)
                        {
                            letter = random.Next(0, letters.Length - 1);
                            Functional.product_name[i] += letters[letter];
                            letter = random.Next(0, letters.Length - 1);
                            Functional.firm[i] += letters[letter];
                            letter = random.Next(0, letters.Length - 1);
                            Input_Reg.name[i] += letters[letter];
                            letter = random.Next(0, letters.Length - 1);
                            Input_Reg.surname[i] += letters[letter];
                            letter = random.Next(0, letters.Length - 1);
                            Input_Reg.password[i] += letters[letter];
                        }
                    }
                }
            }
        }

        private void Input_Click(object sender, EventArgs e)
        {
            this.Hide();
            Input_form input_form = new Input_form();
            input_form.Show();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration_form registration_form = new Registration_form();
            registration_form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Title_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Reference reference = new Reference();
            reference.Show();
        }
    }
}

﻿using System;
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
    public partial class Delete_warehouse : Form
    {
        /* Delete_warehouse - форма удаления элементов массивов информации о товаре склада.
           В данную форму пользователь может попасть из New_warehouse, а из нее вернуться
           в форму Welcome. При удалении склада пользователю надо будет ввести свой пароль
           от аккаунта. */

        public Delete_warehouse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password;
            password = textBox3.Text;

            if(password == Input_Reg.password[Input_Reg.index])
            {
                Array.Clear(Functional.product_name, Input_Reg.index, 1);
                Array.Clear(Functional.firm, Input_Reg.index, 1);
                Array.Clear(Functional.price, Input_Reg.index, 1);
                Array.Clear(Functional.quantity, Input_Reg.index, 1);
                Array.Clear(Functional.number_of_warehouse, Input_Reg.index, 1);
                Array.Clear(Functional.min_party, Input_Reg.index, 1);

                MessageBox.Show("Удаление прошло успешно");
            }
            else
            {
                MessageBox.Show("Пароль не является корректным, введите заного");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = new Welcome();
            welcome.Show();
        }

        private void Delete_warehouse_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void Delete_warehouse_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Reference reference = new Reference();
            reference.Show();
        }
    }
}

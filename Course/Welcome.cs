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
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            label2.Text = ($"{Input_Reg.name[Input_Reg.index]} !");
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

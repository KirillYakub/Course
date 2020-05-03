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
    public partial class Title : Form
    {
        public Title()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
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
    }
}

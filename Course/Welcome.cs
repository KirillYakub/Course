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
    }
}

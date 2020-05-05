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
    public partial class Admin_delete_warehouse : Form
    {
        /* Администратор может открыть данную форму из Database.
           При этом Database не будет закрыта для удобства выбора склада
           для удаления. После удаления массивы информации о товарах
           не уменьшаться с целью не нарушить индесацию, однако под удаляемым
           индексом будет храниться пустота или нулевое значение. Важно понимать, 
           что если администратор в дальнейшем захочет удалить склад под номером 0,
           в котором после его первого удаления будет храниться данное значение,
           то никакая лишняя информация не будет удалена ведь при создании склада
           пользователь не может создать склад с вышесказанным номером. */

        public Admin_delete_warehouse()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password;
            int number_of_delete_warehouse;

            try
            {
                number_of_delete_warehouse = Convert.ToInt32(textBox1.Text);
                password = textBox2.Text;

                for (int i = 0; i < Functional.size; i++)
                {
                    if(number_of_delete_warehouse == Functional.number_of_warehouse[i] && number_of_delete_warehouse > 0 && password == Input_Reg.password[Input_Reg.index])
                    {
                        Array.Clear(Functional.product_name, i, 1);
                        Array.Clear(Functional.firm, i, 1);
                        Array.Clear(Functional.price, i, 1);
                        Array.Clear(Functional.quantity, i, 1);
                        Array.Clear(Functional.number_of_warehouse, i, 1);
                        Array.Clear(Functional.min_party, i, 1);

                        MessageBox.Show($"Удаление склада прошло успешно, перезагрузите страницу для обновления информации");
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Пароль или номер введен некорректно, попробуйте еще раз");
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Admin_delete_warehouse_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}

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
    public partial class New_warehouse : Form
    {
        /* Форма New_warehouse может быть открыта из Welcome.
           В ней пользователь может создать свой склад со своим собственным
           продуктом. При корректном вводе всех необходимых значений в массивах этих
           значений будет добавлена новая ячейка. В данной форме пользователь может удалить
           свой склад, однако пока он не создаст свой склад данная функция будет не доступна.
           Если в дальнейшем пользователь будет удалять свой склад, то размер массива не уменьшится
           в целях не нарушить индексацию, однако значения удаленных элементов будут пусты. 
           Также важно понимать, что пользователь может создать только один свой склад, и если
           в дальнейшем он будет пытаться создать новый склад, то он будет изменять значения раннее
           созданного склада. */

        public New_warehouse()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, firm;
            int price, quantity, number_of_warehouse, min_party;

            try
            {
                name = textBox1.Text;
                firm = textBox2.Text;
                price = Convert.ToInt32(textBox3.Text);
                quantity = Convert.ToInt32(textBox4.Text);
                number_of_warehouse = Convert.ToInt32(textBox5.Text);
                min_party = Convert.ToInt32(textBox6.Text);

                if (name.Length >= 3 && firm.Length >= 3 && price > 0 && quantity > 0 && number_of_warehouse > 0 && min_party > 0)
                {
                    Functional.size = Input_Reg.size;
                    Functional.index = Input_Reg.index;

                    Array.Resize(ref Functional.product_name, Functional.size);
                    Array.Resize(ref Functional.firm, Functional.size);
                    Array.Resize(ref Functional.price, Functional.size);
                    Array.Resize(ref Functional.quantity, Functional.size);
                    Array.Resize(ref Functional.number_of_warehouse, Functional.size);
                    Array.Resize(ref Functional.min_party, Functional.size);

                    Functional.product_name[Functional.index] = name;
                    Functional.firm[Functional.index] = firm;
                    Functional.price[Functional.index] = price;
                    Functional.quantity[Functional.index] = quantity;
                    Functional.number_of_warehouse[Functional.index] = number_of_warehouse;
                    Functional.min_party[Functional.index] = min_party;
                    
                    MessageBox.Show("Данные приняты");
                }
                else
                {
                    MessageBox.Show("Название продукта слишком короткое либо некорректно введено цифровое значение, введите еще раз");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = new Welcome();
            welcome.Show();
        }

        private void New_warehouse_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            MessageBox.Show("Добро пожаловать на страницу создания склада! Если вы не создавали склад раньше, то можете сделать это сейчас. В противном случае данные склада будут изменены после ввода");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Functional.size > 0 && Functional.size > Input_Reg.index)
            {
                this.Hide();
                Delete_warehouse delete_warehouse = new Delete_warehouse();
                delete_warehouse.Show();
            }
            else
            {
                MessageBox.Show("У вас никогда не было своего склада для его удаления");
            }
        }
    }
}

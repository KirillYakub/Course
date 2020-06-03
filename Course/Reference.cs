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
    public partial class Reference : Form
    {
        /*Справка для пользователя о страницах программы.
          Может быть открыта в любой вкладке нажатием кнопки F1. */

        public Reference()
        {
            InitializeComponent();
        }

        private void Reference_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            richTextBox1.Text = "На данной странице у вас есть возможность войти в свой аккаунт если он существует, либо же зарегистрировать новый аккаунт.";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            richTextBox1.Text = "На данной странице вы можете создать новый аккаунт. Все вводимые данные должны быть длинной минимум три символа.";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            richTextBox1.Text = "На данной странице вы можете войти в свой аккаунт если он был раннее создан вами.";
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            richTextBox1.Text = "На данной странице вы можете перейти на вкладки Search, New Warehouse, а также Administration. Страница является основой сайта так как вам здесь доступна большая часть всех функций.";
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            richTextBox1.Text = "На данной странице вы можете создать свой склад. Все вводимые данные должны состоять минимум из трех символов. Учитывайте, что склад может быть только один, и при попытке создать новый склад на одном и том же аккаунте вы измените данные старого склада.";
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            richTextBox1.Text = "На данной странице вы можете удалить свой склад путем ввода пароля от своего аккаунта.";
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            richTextBox1.Text = "На данной странице вы можете найти товар по номеру склада, вывести прайс-лист товаров, а также все товары с минимальной партией 100.";
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            richTextBox1.Text = "На данной странице вы можете войти на сайт от имени администратора при наличии специального пароля.";
        }
    }
}

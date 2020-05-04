using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    static class Program_Title
    {
        /* В Program_Title программа начинает свою работу.
           Будет открыта форма Title, где пользователя
           попросят войти или зарегистрироваться. */

        public static Title title;
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            title = new Title();
            Application.Run(title);
        }
    }
}

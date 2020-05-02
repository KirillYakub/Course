using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    static class Program_Title
    {
        // Главная точка входа для приложения;

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    /* В данных массивах храниться вся информация
       о пользователях и складах. */

    public class Functional
    {
        public static int size, index;
        public static string[] product_name = new string[size];
        public static string[] firm = new string[size];
        public static int[] price = new int[size];
        public static int[] quantity = new int[size];
        public static int[] number_of_warehouse = new int[size];
        public static int[] min_party = new int[size]; 
    }

    public class Input_Reg
    {
        public static int size, index, first_input;
        public static string []name = new string[size];
        public static string []surname = new string[size];
        public static string []password = new string[size];
    }   
}

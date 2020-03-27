using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЦДО
{
    static class Program
    {
        public static string connection = @"Data Source=PANTERKA\SQLEXPRESS;Initial Catalog=CDO;Integrated Security=True";


        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

       

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A4AhsanulKabir300828740
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Form1[] testForm = new Form1[10];

            for (int i = 0; i < 10; i++)
            {
                //array functionality
                testForm[i] = new Form1();
                Console.WriteLine(testForm[i].ToString());
            }
            Console.ReadLine();
        }
    }
}
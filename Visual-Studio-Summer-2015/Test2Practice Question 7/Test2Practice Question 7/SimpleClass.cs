using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2Practice_Question_7
{
    public class SimpleClass
    {
        /// <exception cref="ArgumentNullException"><paramref name="format" /> is null. </exception>
        /// <exception cref="FormatException">The format specification in <paramref name="format" /> is invalid. </exception>
        /// <exception cref="IOException">An I/O error occurred. </exception>
        public static void Calculate(int num1, int num2)
        {
            try
            {
                Console.WriteLine("numbers are: {0} {1}", num1, num2);
            }
            catch (IOException)
            {
                Console.WriteLine("Failed");
            }

            int total = num1 + num2;

            Console.WriteLine("the total for the numbers are: {0}", total);
        }
    }
}
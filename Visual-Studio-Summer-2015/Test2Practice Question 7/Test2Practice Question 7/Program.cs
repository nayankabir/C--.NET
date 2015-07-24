using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2Practice_Question_7
{
    public class Program
    {
        /// <exception cref="IOException">An I/O error occurred. </exception>
        public static void Main(string[] args)
        {
            try
            {
                SimpleClass.Calculate(3, 4);
            }
            catch (IOException)
            {
                Console.WriteLine("Error. Try again.");
            }
        }
    }
}
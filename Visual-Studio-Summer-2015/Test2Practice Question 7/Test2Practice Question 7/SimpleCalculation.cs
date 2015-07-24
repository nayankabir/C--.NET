using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2Practice_Question_7
{
    internal class SimpleCalculation
    {
        private int _firstNumber;
        private int _secondNumber;

        public SimpleCalculation(int firstNumber, int secondNumber)
        {
            this._firstNumber = firstNumber;
            this._secondNumber = secondNumber;

            firstNumber = 5;
            secondNumber = 10;

            Console.WriteLine("{0}", firstNumber);
        }
    }
}
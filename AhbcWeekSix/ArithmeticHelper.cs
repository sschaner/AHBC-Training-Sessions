using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekSix
{
    public class ArithmeticHelper
    {
        public int Sum(int firstNumber, int secondNumber)
        {
            if (firstNumber == secondNumber)
            {
                throw new InvalidOperationException();
            }
            else
            {
                return firstNumber + secondNumber;
            }
        }

        public int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public int Divide(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return firstNumber / secondNumber;
            }
        }
    }
}

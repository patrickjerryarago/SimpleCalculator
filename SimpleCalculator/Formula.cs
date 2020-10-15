using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{

    public delegate int GetAnswer(int num1, int num2);

    class Formula
    {
        public static int getSum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int getDif(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int getMultiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int getDivide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}

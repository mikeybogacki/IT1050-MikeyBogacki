using System;
using System.Collections.Generic;
using System.Text;

namespace inclass5
{
    class myMath
    {
        public int operand1;
        public int operand2;

        public int addNumbers()
        {
            return operand1 + operand2;
        }

        public int addNumbers(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int addNumbers(int num1, int num2)
        {
            int sum;
            sum = num1 + num2;
            return sum;

        }
        public int subtractNumbers(int num1, int num2)
        {
            return num1 - num2;
        }
        public int multiplyNumbers(int num1, int num2)
        {
            return num1 * num2;
        }
        public int divideNumbers(int num1, int num2)
        {
            return num1 / num2;
        }






    }
}

using System;

namespace inclass5
{
    class Program
    {
        static void Main(string[] args)
        {
            myMath object1 = new myMath();

           Console.WriteLine("The sum is " + object1.addNumbers(11, 10));
           Console.WriteLine("The difference is " + object1.subtractNumbers(33, 21));
           Console.WriteLine("The product is " + object1.multiplyNumbers(10, 20));
            Console.WriteLine("The quotient is " + object1.divideNumbers(30, 15));

            object1.operand1 = 10;
            object1.operand2 = 9;

            int sum;
            // overloading addNumbers will output what is defined in class. and not mess with the other addNumber
            sum = object1.addNumbers();
            Console.WriteLine("the sum is " + sum);
            Console.WriteLine("The sum is " + object1.addNumbers(40, 3, 9));


        }
    }
}

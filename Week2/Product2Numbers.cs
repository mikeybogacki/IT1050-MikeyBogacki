using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int product;

            Console.WriteLine("Enter first Integer");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Integer");
            number2 = Convert.ToInt32(Console.ReadLine());

            product = number1 * number2;

            Console.WriteLine("The product is " + product);

        }
    }
}

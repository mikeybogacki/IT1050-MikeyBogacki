using System;

namespace week2
{
     class Addition
    {
        public static void Main(string[] args)
        {
            int number1;
            int number2;
            int sum;
            Console.WriteLine("Enter First Integer:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Integer:");
            number2 = Convert.ToInt32(Console.ReadLine());
            sum = number2 + number1;
            Console.WriteLine("The sum is " + sum);
         

        }
    }
}

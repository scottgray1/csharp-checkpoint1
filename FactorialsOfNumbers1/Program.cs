using System;

namespace FactorialsOfNumbers1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i = 0; i > 0; i--)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("The factorial of {0} is {1}", number, factorial);
            Console.ReadLine();
        }
    }
}

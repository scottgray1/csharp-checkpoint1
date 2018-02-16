using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (count < 4)
            {

                int random = new Random().Next(1, 11);

                Console.WriteLine("Please enter a number between 1 and 10");

                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("Random Number: " + random);

                if (random == number)
                {
                    Console.WriteLine("Result: You won!");
                    count++;
                }
                else
                {
                    Console.WriteLine("Result: You lost");
                    count++;
                }

            }
        }
    }
}

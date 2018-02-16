using System;
using System.Linq;


namespace SeriesOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some numbers separated by commas:");
            string[] input = Console.ReadLine().Split(',');
            int[] array = Array.ConvertAll(input, int.Parse);

            int biggestNumber = array.Max();

            Console.WriteLine("The Largest number is:{0}", biggestNumber);
            Console.ReadLine();

            /* if we had to iterate through a string:
             foreach (string item in input)
             {
             int.TryParse(item, out number);
             if  (number != 0)
             {
             maxNumber = number;
             }
             else 
             {
             maxNumber = (number > maxNumber) ? number : maxNumber;
             }
             }*/
        }

    }
}

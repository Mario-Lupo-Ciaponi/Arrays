using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sumOfEvenNumbers = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sumOfEvenNumbers += number;
                }
            }

            Console.WriteLine(sumOfEvenNumbers);
        }
    }
}

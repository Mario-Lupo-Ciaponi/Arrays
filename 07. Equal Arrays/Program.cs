using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArrayToCompare = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArrayToCompare = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sum = 0;

            for (int i = 0; i < firstArrayToCompare.Length; i++)
            {
                if (firstArrayToCompare[i] != secondArrayToCompare[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index.");
                    return;
                }
                else
                {
                    sum += firstArrayToCompare[i];
                }
            }

            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}

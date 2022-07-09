using System;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayToReverse = Console.ReadLine().Split(' ');

            Array.Reverse(arrayToReverse);

            Console.WriteLine(String.Join(' ', arrayToReverse));
        }
    }
}

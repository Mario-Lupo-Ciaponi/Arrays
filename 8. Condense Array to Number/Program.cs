﻿using System;
using System.Linq;

namespace _8._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] condanse = new int[numbers.Length - 1];
            
            while (numbers.Length < 1)
            {
                for (int i = 0; i < condanse.Length - 1; i++)
                {
                    condanse[i] = numbers[i] + numbers[i + 1];
                    if (i == numbers.Length - 2)
                    {
                        numbers = condanse;
                        condanse = new int[numbers.Length - 1];
                    }
                }
            }

            Console.WriteLine(numbers[0]);
        }
    }
}

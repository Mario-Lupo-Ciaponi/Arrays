using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mount = int.Parse(Console.ReadLine());
            string[] mountsName = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (mount >= 1 && mount<= 7)
            {
                Console.WriteLine($"{mountsName[mount - 1]}");
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}

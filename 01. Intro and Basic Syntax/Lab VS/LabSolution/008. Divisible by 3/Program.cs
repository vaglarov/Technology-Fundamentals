using System;

namespace _008._Divisible_by_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int endPointInput = int.Parse(Console.ReadLine());
            int sumNumbers = 0;
            int startNumber = 1;
            int count = 1;
            while (count <= endPointInput)
            {
                Console.WriteLine(startNumber);
                sumNumbers += startNumber;
                startNumber += 2;
                count++;
            }
            Console.WriteLine($"Sum: {sumNumbers}");

        }
    }
}
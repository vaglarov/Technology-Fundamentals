using System;

namespace _105._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int starNumberFromASCII = int.Parse(Console.ReadLine());
            int endNumberFromASCII = int.Parse(Console.ReadLine());
            for (int i = starNumberFromASCII; i <= endNumberFromASCII; i++)
            {
                Console.Write($"{(char)i} ");
            }
            Console.WriteLine();
        }
    }
}

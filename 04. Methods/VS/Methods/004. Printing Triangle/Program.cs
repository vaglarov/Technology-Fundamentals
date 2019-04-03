using System;

namespace _004._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberSteps = int.Parse(Console.ReadLine());
            PrintUpperSide(numberSteps);
            PrintDownSide(numberSteps - 1);
        }

        private static void PrintDownSide(int numberSteps)
        {
            for (int row = numberSteps; row >= 1; row--)
            {
                PrintNumbersInRow(row);
                Console.WriteLine();
            }
        }

        private static void PrintUpperSide(int numberSteps)
        {
            for (int row = 1; row <= numberSteps; row++)
            {
                PrintNumbersInRow(row);
                Console.WriteLine();
            }
        }

        private static void PrintNumbersInRow(int row)
        {
            for (int number = 1; number <= row; number++)
            {
                if (number == row)
                {
                    Console.Write(number);
                }
                else
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}

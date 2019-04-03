using System;

namespace _107._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            PrintROW(numberInput);
        }

        private static void PrintROW(int numberInput)
        {
            for (int i = 0; i < numberInput; i++)
            {
                PrintCol(numberInput);
                Console.WriteLine();
            }
        }

        private static void PrintCol(int numberInput)
        {
            for (int i = 0; i < numberInput; i++)
            {
                if (i == numberInput - 1)
                {
                    Console.Write(numberInput);
                }
                else
                {
                    Console.Write($"{numberInput} ");
                }
            }
        }
    }
}

using System;

namespace _007._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namesInput = new string[3];
            for (int i = 0; i < 3; i++)
            {
                namesInput[i] = Console.ReadLine();
            }
            Console.WriteLine($"{namesInput[0]}{namesInput[2]}{namesInput[1]}");
        }
    }
}

using System;
using System.Collections.Generic;

namespace _101._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int result = ReturnMinNumber(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(result);
        }

        private static int ReturnMinNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            List<int> numbersList = new List<int>();
            numbersList.Add(firstNumber);
            numbersList.Add(secondNumber);
            numbersList.Add(thirdNumber);
            numbersList.Sort();
            return numbersList[0];
        }
    }
}

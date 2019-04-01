using System;

namespace _003._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersInputNumbers = int.Parse(Console.ReadLine());
            decimal sumNumbers = 0;
            for (int i = 0; i < numbersInputNumbers; i++)
            {
                decimal numberInput = decimal.Parse(Console.ReadLine());
                sumNumbers += numberInput;
            }
            Console.WriteLine(sumNumbers);
        }
    }
}

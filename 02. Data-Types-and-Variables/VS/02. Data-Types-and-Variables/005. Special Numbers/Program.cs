using System;

namespace _005._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            for (int i = 1; i <=numberInput; i++)
            {
                int sum = 0;
                int number = i;
                while (number > 0)
                {
                    int lastDigit = number % 10;
                    sum += lastDigit;
                    number = number / 10;
                }
                if (sum==5|| sum ==7 || sum ==11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}

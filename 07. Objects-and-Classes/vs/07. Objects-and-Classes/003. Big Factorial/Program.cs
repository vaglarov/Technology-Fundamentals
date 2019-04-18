 using System;
using System.Numerics;

namespace _003._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            long inputNumber = long.Parse(Console.ReadLine());
            BigInteger result = 1; 
            for (int i = 1; i <= inputNumber; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}

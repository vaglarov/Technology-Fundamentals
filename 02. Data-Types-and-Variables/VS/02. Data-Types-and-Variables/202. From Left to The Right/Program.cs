using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _202._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            // read data
            BigInteger numberLinesInput = BigInteger.Parse(Console.ReadLine());
            for (int i = 0; i < numberLinesInput; i++)
            {
                BigInteger[] argInput = Console.ReadLine()
                    .Split(' ')
                    .Select(BigInteger.Parse)
                    .ToArray();
                BigInteger firstSum = SumOfDigits(argInput[0]);
                BigInteger secondSum = SumOfDigits(argInput[1]);
                if (firstSum >= secondSum)
                {
                    Console.WriteLine(firstSum);
                }
                else
                {
                    Console.WriteLine(secondSum);
                }
            }
        }

        // mehtod
        private static BigInteger SumOfDigits(BigInteger inputNumber)
        {
            if (inputNumber < 0)
            {
                inputNumber *= -1;
            }
            BigInteger sumDigits = 0;
            while (inputNumber > 0)
            {
                sumDigits += (BigInteger)(inputNumber % 10);
                inputNumber = inputNumber / 10;
            }
            return sumDigits;
        }
    }
}

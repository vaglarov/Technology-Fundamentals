using System;

namespace _010._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int numberInput = int.Parse(Console.ReadLine());
            int sumEven=SumOfEvenDigits(numberInput);
           int sumOdd = SumOfOddDigits(numberInput);
           var sumResult = sumEven * sumOdd;
            Console.WriteLine(sumResult);
        }

        private static int SumOfOddDigits(int number)
        {
            int sumResult = default(int);
            if (number < 0)
            {
                number = number * (-1);
            }
            while (number > 0)
            {
                var digits = number % 10;
                if (digits % 2 == 1)
                {
                    sumResult += number % 10;
                }
                number /= 10;
            }
            return sumResult;
        }

        private static int SumOfEvenDigits(int number)
        {
            int sumResult = default(int);
            if (number < 0)
            {
                number = number * (-1);
            }
            while (number>0)
            {
                var digits= number % 10;
                if (digits%2==0)
                {
                sumResult += number % 10;
                }
                number /= 10;
            }
            return sumResult;

        }
    }
}

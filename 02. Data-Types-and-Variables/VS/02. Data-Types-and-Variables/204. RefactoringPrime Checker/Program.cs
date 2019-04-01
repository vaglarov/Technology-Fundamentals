using System;

namespace _204._RefactoringPrime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReadData
            int startPeriod = 2;
            int ednPeriodInput= int.Parse(Console.ReadLine());
            for (int i = startPeriod; i <= ednPeriodInput; i++)
            {
                bool isPrime = true;
                for (int divide = 2; divide < i; divide++)
                {
                    if (i % divide == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                //Print result
                Console.WriteLine($"{i} -> {isPrime.ToString().ToLower()}");
            }

        }
    }
}

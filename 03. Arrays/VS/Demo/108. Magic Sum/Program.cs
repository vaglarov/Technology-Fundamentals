using System;
using System.Collections.Generic;
using System.Linq;

namespace _108._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List < int >numbersInput= Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int currentSum = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbersInput.Count; i++)
            {
                for (int j = i+1; j < numbersInput.Count; j++)
                {
                    int sum = numbersInput[i] + numbersInput[j];
                    if (currentSum==sum)
                    {
                        Console.WriteLine($"{numbersInput[i]} {numbersInput[j]}");
                    }
                }
            }
        }
    }
}

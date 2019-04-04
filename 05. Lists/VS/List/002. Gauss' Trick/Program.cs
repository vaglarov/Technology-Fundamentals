using System;
using System.Linq;
using System.Collections.Generic;

namespace _003._Gauss__Trick
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            List<double> numbersListR = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            List<double> numbersList = numbersListR;
            List<double> numberResultList = new List<double>();
            for (int i = 0; i < numbersList.Count / 2; i++)
            {
                double first = numbersList[i];
                double last = numbersList[(numbersList.Count - 1 - i)];
                double numberToAdd = first + last;
                numberResultList.Add(numberToAdd);
            }
            if (numbersList.Count % 2 == 1)
            {
                double middleElement = numbersList[numbersList.Count / 2];
                numberResultList.Add(middleElement);
            }
            Console.WriteLine(string.Join(' ', numberResultList));
        }
    }
}

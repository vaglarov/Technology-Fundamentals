using System;
using System.Collections.Generic;
using System.Linq;

namespace _107._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int countMax = 0;
            int count = 0;
            int elementCount = 0;
            List<int> longestRowElement = new List<int>();
            for (int i = 1; i < numbersInput.Count; i++)
            {
                if (numbersInput[i-1]==numbersInput[i])
                {
                    count++;
                    if (count>countMax)
                    {
                        countMax = count;
                        elementCount = numbersInput[i];
                    }
                }
                else
                {
                    count = 0;
                }
            }
            if (countMax>=1)
            {

            for (int i = 0; i <= countMax; i++)
            {
                longestRowElement.Add(elementCount);
            }
            }
            Console.WriteLine(string.Join(" ",longestRowElement));
        }
    }
}

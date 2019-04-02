using System;
using System.Collections.Generic;
using System.Linq;

namespace _105._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersInput = Console.ReadLine().Split(' ' ).Select(int.Parse).ToList();
            List<int> isTopIntegerInList = new List<int>();
            for (int i = 0; i < numbersInput.Count; i++)
            {
                bool isTopInteger = true;
                for (int j = i+1; j < numbersInput.Count; j++)
                {
                    if (numbersInput[i]<=numbersInput[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    isTopIntegerInList.Add(numbersInput[i]);
                }
            }
            Console.WriteLine(string.Join(' ',isTopIntegerInList));


        }
    }
}

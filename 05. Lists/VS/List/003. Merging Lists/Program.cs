using System;
using System.Collections.Generic;
using System.Linq;

namespace _003._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var firstListInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var secondList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var resultList = MergeTwoList(firstListInput,secondList);
            Console.WriteLine(string.Join(" ",resultList));
        }

        private static List<int> MergeTwoList(List<int> firstList, List<int> secondList)
        {
            var resultList = new List<int>();
            if (firstList.Count>=secondList.Count)
            {
                for (int i = 0; i < firstList.Count; i++)
                {
                    if (i < secondList.Count)
                    {
                        resultList.Add(firstList[i]);
                        resultList.Add(secondList[i]);
                    }
                    else
                    {
                        resultList.Add(firstList[i]);
                    }
                }
                return resultList;
            }
            else
            {
                for (int i = 0; i < secondList.Count; i++)
                {
                    if (i < firstList.Count)
                    {
                        resultList.Add(firstList[i]);
                        resultList.Add(secondList[i]);
                    }
                    else
                    {
                        resultList.Add(secondList[i]);
                    }
                }
                return resultList;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _005._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var listInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var resultList = RemoveNegativValue(listInput);
            resultList.Reverse();
            if (resultList.Count==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
            Console.WriteLine(string.Join(" ",resultList));
            }
        }

        private static List<int> RemoveNegativValue(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]<0)
                {
                    list.RemoveAt(i);
                    i -= 1;
                }
            }
            return list;
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var listNumber = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            var dictNumer = new SortedDictionary<int, int>();
            foreach (var item in listNumber)
            {
                if (!dictNumer.ContainsKey(item))
                {
                    dictNumer.Add(item, 1);
                }
                else
                {
                    dictNumer[item]++;
                }
            }
            foreach (var item in dictNumer)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
//            2-> 3
//8-> 2

        }
    }
}

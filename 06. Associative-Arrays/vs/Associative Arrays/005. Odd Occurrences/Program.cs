using System;
using System.Linq;
using System.Collections.Generic;

namespace _005._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var listInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var dictWordAll = new Dictionary<string, int>();
            foreach (var item in listInput)
            {
                if (!dictWordAll.ContainsKey(item.ToLower()))
                {
                    dictWordAll.Add(item.ToLower(), 1);
                }
                else
                {
                dictWordAll[item.ToLower()]++;
                }
            }
            var dictOddWord = new Dictionary< string,int>();
            foreach (var item in dictWordAll)
            {
                if (item.Value%2==1)
                {
                    dictOddWord.Add(item.Key,item.Value);
                }
            }
            foreach (var item in dictOddWord)
            {
                Console.Write($"{item.Key} ");
            }
            Console.WriteLine();
        }
    }
}

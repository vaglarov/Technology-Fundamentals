using System;
using System.Collections.Generic;
using System.Linq;

namespace _107._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var listInputFirstTry = new List<List<int>>();
            var listInpit = Console.ReadLine().
                 Split("|", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < listInpit.Length; i++)
            {
                listInputFirstTry.Add(listInpit[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).
                    Select(int.Parse).
                    ToList());
            }
            // listInputFirstTry.Sort((a, b) => b[0].CompareTo(a[0]));
            listInputFirstTry.Reverse();
            for (int i = 0; i < listInputFirstTry.Count; i++)
            {
                for (int j = 0; j < listInputFirstTry[i].Count; j++)
                {
                    Console.Write($"{listInputFirstTry[i][j]} ");
                }
            }
            Console.WriteLine();
        }
    }
}

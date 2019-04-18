using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using System.Text;

namespace _002._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            var wordsInLine = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                ToList();
            List<string> words2 = new List<string>();
            Random ran = new Random();
            while (wordsInLine.Count > 0)
            {
                int randomIndex = ran.Next(wordsInLine.Count);
                words2.Add(wordsInLine[randomIndex]);
                wordsInLine.RemoveAt(randomIndex);
            }
            Console.WriteLine(string.Join(Environment.NewLine, words2));
        }
    }
}

using System;
using System.Collections.Generic;

namespace _002._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int numberCople = int.Parse(Console.ReadLine());
            var dictSinonims = new Dictionary<string, List<string>>();
            for (int i = 0; i < numberCople; i++)
            {
                var wordKey = Console.ReadLine();
                var wordValue = Console.ReadLine();
                if (!dictSinonims.ContainsKey(wordKey))
                {
                    dictSinonims.Add(wordKey, new List<string>());
                }
                    dictSinonims[wordKey].Add(wordValue);
            }
            foreach (var item in dictSinonims)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}

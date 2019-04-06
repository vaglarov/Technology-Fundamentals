using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictDict = new Dictionary<string, List<string>>();
            var dictResult = new Dictionary<string, List<string>>();
            var commandInput = Console.ReadLine();
            var comandSplit = commandInput.Split(" | ");
            for (int i = 0; i < comandSplit.Length; i++)
            {
                var lineSplit = comandSplit[i].ToString().Split(": ");
                var word = lineSplit[0];
                if (lineSplit.Length > 1)
                {
                    var definicion = lineSplit[1];
                    if (!dictDict.ContainsKey(word))
                    {
                        dictDict.Add(word, new List<string>());
                    }
                    if (!dictDict[word].Contains(definicion))
                    {
                        dictDict[word].Add(definicion);
                    }

                }

            }
            var nextCommandFirst = Console.ReadLine();
            var wordsInResult = nextCommandFirst.Split(" | ");
            for (int i = 0; i < wordsInResult.Length; i++)
            {
                var checkedWord = wordsInResult[i];
                if (dictDict.ContainsKey(checkedWord))
                {
                    var result = dictDict[checkedWord];
                    dictResult.Add(checkedWord, result);

                }
            }
            foreach (var kvp in dictResult.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var item in kvp.Value.OrderByDescending(x => x.Length).ToList())
                {
                    Console.WriteLine($" -{item}");
                }
            }
            var nextCommand = Console.ReadLine();
            if (nextCommand == "List")
            {
                foreach (var item in dictDict.OrderBy(x=>x.Key))
                {
                    Console.Write($"{item.Key} ");
                }
            }
            Console.WriteLine();
            
        }
    }
}

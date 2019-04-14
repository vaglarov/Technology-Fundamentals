using System;
using System.Collections.Generic;
using System.Linq;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictItem = new Dictionary<string, List<string>>();
            var line = string.Empty;
            while ((line = Console.ReadLine()) != "END")
            {
                var commands = line.Split(new string[] { "->", "," }, StringSplitOptions.RemoveEmptyEntries);
                //add In Dictionary
                if (commands.Length > 2)
                {
                    var nameMountain = commands[1];
                    if (!dictItem.ContainsKey(nameMountain))
                    {
                        dictItem.Add(nameMountain, new List<string>());
                    }
                    for (int i = 2; i < commands.Length; i++)
                    {
                        var itemName = commands[i];
                        dictItem[nameMountain].Add(itemName);
                    }
                }
                //Remove
                else
                {
                    var mountainToRemove = commands[1];
                    if (dictItem.ContainsKey(mountainToRemove))
                    {
                        dictItem.Remove(mountainToRemove);
                    }

                }

            }
            //print
            Console.WriteLine("Stores list:");
            foreach (var kvp in dictItem.OrderByDescending(x => x.Value.Count).ThenByDescending(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }
        }
    }
}

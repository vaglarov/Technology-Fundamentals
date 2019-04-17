using System;
using System.Collections.Generic;
using System.Linq;

namespace _103._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var importantItem = new Dictionary<string, int>() {
            {"shards",0 },
            { "fragments",0 },
            { "motes",0 }
            };
            var otherMatirial = new Dictionary<string, int>();
                bool haveWinner = false;
            while (!haveWinner)
            {
                var commandsArr = Console.ReadLine().ToLower().Split(" ");
                for (int i = 0; i < commandsArr.Length; i += 2)
                {

                    int quantity = int.Parse(commandsArr[i]);
                    var type = commandsArr[i + 1];
                    if (importantItem.ContainsKey(type))
                    {
                        importantItem[type] += quantity;
                    }
                    else if (!otherMatirial.ContainsKey(type))
                    {
                        otherMatirial.Add(type, quantity);
                    }
                    else
                    {
                        otherMatirial[type] += quantity;
                    }
                    if (importantItem["shards"] >= 250 || importantItem["fragments"] >= 250 || importantItem["motes"] >= 250)
                    {
                        importantItem[type] -= 250;
                        if (type == "shards")
                        {
                            Console.WriteLine($"Shadowmourne obtained!");
                        }
                        else if (type == "fragments")
                        {
                            Console.WriteLine($"Valanyr obtained!");
                        }
                        else if (type == "motes")
                        {
                            Console.WriteLine($"Dragonwrath obtained!");
                        }
                        haveWinner = true;
                        break;
                    }
                }
            }

            foreach (var kvp in importantItem.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                
            }
            foreach (var kvp in otherMatirial.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }



        }
    }
}


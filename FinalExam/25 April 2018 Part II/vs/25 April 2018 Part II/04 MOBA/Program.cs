using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_MOBA
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var dictPlayer = new Dictionary<string, Dictionary<string, int>>();
            while ((input = Console.ReadLine()) != "Season end")
            {
                var command = input.Split(new string[] { " -> ", " vs " }, StringSplitOptions.RemoveEmptyEntries);
                //Add in dict
                if (command.Length == 3)
                {
                    var nameToAdd = command[0];
                    var gameToAdd = command[1];
                    var pointToAdd = int.Parse(command[2]);
                    if (!dictPlayer.ContainsKey(nameToAdd))
                    {
                        dictPlayer.Add(nameToAdd, new Dictionary<string, int>());
                    }
                    if (!dictPlayer[nameToAdd].ContainsKey(gameToAdd))
                    {
                        dictPlayer[nameToAdd].Add(gameToAdd, pointToAdd);
                    }
                    else if (dictPlayer[nameToAdd][gameToAdd] < pointToAdd)
                    {
                        dictPlayer[nameToAdd][gameToAdd] = pointToAdd;
                    }
                }
                else
                {
                    var nameFirstPlayer = command[0];
                    var nameSecondPlayer = command[1];
                    if (dictPlayer.ContainsKey(nameFirstPlayer) && dictPlayer.ContainsKey(nameSecondPlayer))
                    {
                        foreach (var kvpFirstPlayer in dictPlayer[nameFirstPlayer])
                        {
                            if (dictPlayer[nameSecondPlayer].ContainsKey(kvpFirstPlayer.Key))
                            {
                                var firstTotalPoint = dictPlayer[nameFirstPlayer].Values.Sum();
                                var secondTotalPoint = dictPlayer[nameSecondPlayer].Values.Sum();
                                if (firstTotalPoint > secondTotalPoint)
                                {
                                    dictPlayer.Remove(nameSecondPlayer);
                                    break;
                                }
                                else if (secondTotalPoint>firstTotalPoint)
                                {
                                    dictPlayer.Remove(nameFirstPlayer);
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            //print
            foreach (var kvp in dictPlayer.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Values.Sum()} skill");
                foreach (var item in kvp.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {item.Key} <::> {item.Value}");
                }
            }
        }
    }
}


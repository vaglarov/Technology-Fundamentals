using System;
using System.Collections.Generic;
using System.Linq;

namespace _203._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faker->Tank-> 250
            //Pesho vs Faker
            //Season end

            string command = string.Empty;
            var dictPlayer = new Dictionary<string, Dictionary<string, int>>();
            while ((command = Console.ReadLine()) != "Season end")
            {
                var commandArr = command.Split(" ");
                if (commandArr[1] == "->")
                {
                    var playerName = commandArr[0];
                    var position = commandArr[2];
                    var skill = int.Parse(commandArr[4]);
                    if (!dictPlayer.ContainsKey(playerName))
                    {
                        dictPlayer.Add(playerName, new Dictionary<string, int>());
                        dictPlayer[playerName].Add(position, skill);
                    }
                    else
                    {
                        if (!dictPlayer[playerName].ContainsKey(position))
                        {
                            dictPlayer[playerName].Add(position, skill);
                        }
                        else if (dictPlayer[playerName][position] < skill)
                        {
                            dictPlayer[playerName].Remove(position);
                            dictPlayer[playerName].Add(position, skill);
                        }
                    }
                }
                else if (commandArr[1] == "vs")
                {
                    var firstPlayer = commandArr[0];
                    var secondPlayer = commandArr[2];
                    if (dictPlayer.ContainsKey(firstPlayer)&&dictPlayer.ContainsKey(secondPlayer))
                    {
                        bool haveCommanPosition = HameCommandPosition(firstPlayer, secondPlayer, dictPlayer);
                        if (haveCommanPosition)
                        {
                            var totalSkillFirst = dictPlayer[firstPlayer].Values.Sum();
                            var totalSkillSecond= dictPlayer[secondPlayer].Values.Sum();
                            if (totalSkillFirst>totalSkillSecond)
                            {
                                dictPlayer.Remove(secondPlayer);
                            }
                            else if (totalSkillSecond>totalSkillFirst)
                            {
                                dictPlayer.Remove(firstPlayer);
                            }
                        }
                    }
                }

            }
            //print
            //ordered by total skill in desecending order, then ordered by player name in ascending order
            foreach (var player in dictPlayer.OrderByDescending(x=>x.Value.Values.Sum()).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                //Foreach player print their position and skill, ordered desecending by skill, then ordered by position name in ascending order.
                foreach (var kvp in player.Value.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                    //- Support <::> 250
                    Console.WriteLine($"- {kvp.Key} <::> {kvp.Value}");

                }
            }
        }

        private static bool HameCommandPosition(string firstPlayer, string secondPlayer, Dictionary<string, Dictionary<string, int>> dictPlayer)
        {
            foreach (var positionFirst in dictPlayer[firstPlayer])
            {
                foreach (var positionSecond in dictPlayer[secondPlayer])
                {
                    if ( positionFirst.Key==positionSecond.Key)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

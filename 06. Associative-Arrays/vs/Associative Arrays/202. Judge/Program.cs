using System;
using System.Linq;
using System.Collections.Generic;

namespace _202._Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var usersDict = new Dictionary<string, Dictionary<string, int>>();
            var contestDict = new Dictionary<string, Dictionary<string, int>>();
            var command = string.Empty;
            while ((command = Console.ReadLine()) != "no more time")
            {
                var commandsSplit = command.Split(" -> ");
                var userName = commandsSplit[0];
                var contestName = commandsSplit[1];
                var pointContest = int.Parse(commandsSplit[2]);
                //DictUsers
                if (!usersDict.ContainsKey(userName))
                {
                    usersDict.Add(userName, new Dictionary<string, int>());
                    usersDict[userName].Add(contestName, pointContest);
                }
                else
                {
                    if (!usersDict[userName].ContainsKey(contestName))
                    {
                        usersDict[userName].Add(contestName, pointContest);
                    }
                    else if (usersDict[userName].ContainsKey(contestName) && usersDict[userName][contestName] < pointContest)
                    {
                        usersDict[userName].Remove(contestName);
                        usersDict[userName].Add(contestName, pointContest);
                    }
                }
            }
            foreach (var kvpUser in usersDict)
            {
                foreach (var kvp in kvpUser.Value)
                {
                    if (!contestDict.ContainsKey(kvp.Key))
                    {
                        contestDict.Add(kvp.Key, new Dictionary<string, int>());
                    }
                    if (!contestDict[kvp.Key].ContainsKey(kvpUser.Key))
                    {
                        contestDict[kvp.Key].Add(kvpUser.Key, 0);
                    }
                    contestDict[kvp.Key][kvpUser.Key] += kvp.Value;
                }

            }
            //print 
            //Algo: 3 participants
            foreach (var kvp in contestDict.OrderByDescending(x=>x.Value.Values.Count()))
            {
            var tableNumber = 1;
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Values.Count()} participants");
                foreach (var item in kvp.Value.OrderByDescending(x=>x.Value))
                {
                    //1.Pesho <::> 400
                    Console.WriteLine($"{tableNumber}. {item.Key} <::> {item.Value}");
                    tableNumber++;
                }
            }
            // Individual standings:
            //1.Mimi-> 600
            Console.WriteLine("Individual standings:");
            var count = 1;
            foreach (var kvp in usersDict.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{count}. {kvp.Key} -> {kvp.Value.Values.Sum()}");
                count++;
            }
        }
    }
}

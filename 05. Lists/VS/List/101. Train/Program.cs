using System;
using System.Collections.Generic;
using System.Linq;

namespace _101._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var wagonsTrainList = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();
            int capacityWagons = int.Parse(Console.ReadLine());
            string commands = Console.ReadLine();
            while (commands!="end")
            {
                var commandsInList = commands
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (commandsInList[0]=="Add")
                {
                    wagonsTrainList.Add(int.Parse(commandsInList[1]));
                }
                else
                {
                    for (int i = 0; i <wagonsTrainList.Count; i++)
                    {
                        if (wagonsTrainList[i]+int.Parse(commandsInList[0])<=capacityWagons)
                        {
                            wagonsTrainList[i] += int.Parse(commandsInList[0]);
                            break;
                        }
                    }
                }
                commands = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ',wagonsTrainList));
        }
    }
}

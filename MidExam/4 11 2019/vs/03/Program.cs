using System;
using System.Collections.Generic;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            var listString = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string line = Console.ReadLine();
            while (line != "Retire!")
            {
                var commandsArr = line.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                switch (commandsArr[0])
                {
                    case "Start":
                        listString.Add(commandsArr[1]);
                        break;
                    case "Complete":
                        if (listString.Contains(commandsArr[1]))
                        {
                            listString.Remove(commandsArr[1]);
                        }
                        break;
                    case "Renew":
                        if (listString.Contains(commandsArr[1]))
                        {
                            listString.Remove(commandsArr[1]);
                            listString.Add(commandsArr[1]);
                        }
                        break;
                    case "Side Quest":
                        string[] sideCommand = commandsArr[1].Split(":",StringSplitOptions.RemoveEmptyEntries);
                        if (listString.Contains(sideCommand[0]))
                        {
                            var index =listString.IndexOf(sideCommand[0]);
                            if (!listString.Contains(sideCommand[1]))
                            {

                            listString.Insert(index + 1, sideCommand[1]);
                            }
                        }
                        break;



                }
                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", listString));
        }
    }
}

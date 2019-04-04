using System;
using System.Linq;

namespace _006._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var inputList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            while (command!="end")
            {
                var listCommands = command.Split(' ',StringSplitOptions.RemoveEmptyEntries).ToList();
                switch (listCommands[0])
                {
                    case "Add":
                        inputList.Add(int.Parse(listCommands[1]));
                        break;
                    case "Remove":
                        inputList.Remove(int.Parse(listCommands[1]));
                        break;
                    case "RemoveAt":
                        inputList.RemoveAt(int.Parse(listCommands[1]));
                        break;
                    case "Insert":
                        inputList.Insert(int.Parse(listCommands[2]), int.Parse(listCommands[1]));
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ',inputList));
        }
    }
}

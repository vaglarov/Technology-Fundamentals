using System;
using System.Linq;

namespace _102._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var listInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var commandLine = Console.ReadLine().Split();
            while (commandLine[0]!="end")
            {
                switch (commandLine[0])
                {
                    case "Delete":
                        var numberToDelete = int.Parse(commandLine[1]);
                        listInput.RemoveAll(x=>x==numberToDelete);
                        break;
                    case "Insert":
                        var numberToInsert=int.Parse(commandLine[1]);
                        var indexToinser = int.Parse(commandLine[2]);
                        listInput.Insert(indexToinser, numberToInsert);
                        break;
                }
                commandLine = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(' ',listInput));
        }
    }
}

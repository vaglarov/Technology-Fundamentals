using System;
using System.Collections.Generic;

namespace _102._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string command = Console.ReadLine();
            var dictVolume = new Dictionary<string, int>();
            while (command!="stop")
            {
                var keyDict = command;
                var numberValue = int.Parse(Console.ReadLine());
                if (!dictVolume.ContainsKey(keyDict))
                {
                    dictVolume.Add(keyDict, 0);
                }
                dictVolume[keyDict] += numberValue;
                command = Console.ReadLine();
            }
            foreach (var item in dictVolume)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

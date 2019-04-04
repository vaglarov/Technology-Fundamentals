using System;
using System.Collections.Generic;

namespace _103._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var listGuest = new List<string>();
            int numberCommand = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberCommand; i++)
            {
                var commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                switch (commands[2])
                {
                    case"going!":
                        if (listGuest.Contains(commands[0]))
                        {
                            Console.WriteLine($"{commands[0]} is already in the list!");
                            break;
                        }
                        listGuest.Add(commands[0]);
                        break;
                    case "not":
                        if (!listGuest.Contains(commands[0]))
                        {
                            Console.WriteLine($"{commands[0]} is not in the list!");
                            break;
                        }
                        listGuest.Remove(commands[0]);
                        break;
                }

            }
            for (int i = 0; i < listGuest.Count; i++)
            {
                Console.WriteLine(listGuest[i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace _105._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            //            5
            //register John CS1234JS
            //register George JAVA123S
            //register Andy AB4142CD
            //register Jesica VR1223EE
            //unregister Andy
            Console.ForegroundColor = ConsoleColor.Yellow;
            int numberLine = int.Parse(Console.ReadLine());
            var dictUsers = new Dictionary<string, string>();
            for (int i = 1; i <= numberLine; i++)
            {
                var commant = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = commant[1];
                switch (commant[0])
                {
                    case "register":
                        string carId = commant[2];
                        if (!dictUsers.ContainsKey(name))
                        {
                            dictUsers.Add(name, carId);
                            Console.WriteLine($"{name} registered {carId} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {carId}");
                        }
                        
                        break;
                    case "unregister":
                        if (!dictUsers.ContainsKey(name))
                        {
                            Console.WriteLine($"ERROR: user {name} not found");
                        }
                        else
                        {
                            dictUsers.Remove(name);
                            Console.WriteLine($"{name} unregistered successfully");
                        }
                        break;
                }
            }
            foreach (var kvp in dictUsers)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}

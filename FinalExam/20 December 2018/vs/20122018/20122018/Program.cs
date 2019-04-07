using System;
using System.Collections.Generic;
using System.Linq;

namespace _20122018
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictGame = new Dictionary<string, Game>();
            var inputLine = Console.ReadLine();
            var inputSplit = inputLine.Split(", ");
            for (int i = 0; i < inputSplit.Length; i++)
            {
                var splitInput = inputSplit[i];
                var nameGame = string.Empty;
                if (splitInput.Contains("-"))
                {
                    var group=splitInput.Split("-");
                    nameGame = group[0];
                    var gamePrice =double.Parse( group[1]);
                    if (!dictGame.ContainsKey(nameGame))
                    {
                        dictGame.Add(nameGame, new Game(nameGame, gamePrice));
                    }
                }
                else if (splitInput.Contains(":"))
                {
                    var group = splitInput.Split(":");
                    nameGame = group[0];
                    var gameDVC = group[1];
                    if (dictGame.ContainsKey(nameGame))
                    {
                        dictGame[nameGame].DLC = gameDVC;
                        dictGame[nameGame].Price *= 1.2;
                    }
                }

            }
            //Corect price
            //lower the prices of all the games by 20 % if they don't have a DLC and by 50% if they do
            foreach (var kvp in dictGame.Where(x=>x.Value.DLC== string.Empty))
            {
                kvp.Value.Price *= 0.8;
            }
            foreach (var kvp in dictGame.Where(x => x.Value.DLC != string.Empty))
            {
                kvp.Value.Price *= 0.5;
            }

            //print
            foreach (var kvp in dictGame.Where(x => x.Value.DLC != string.Empty).OrderBy(x=>x.Value.Price))
            {
                //League of Leg Ends - DoaT - 6.00
                Console.WriteLine($"{kvp.Key} - {kvp.Value.DLC} - {kvp.Value.Price:f2}");
            }
            foreach (var kvp in dictGame.Where(x => x.Value.DLC == string.Empty).OrderByDescending(x => x.Value.Price))
            {
                //FullLife 3 - 48.00
                Console.WriteLine($"{kvp.Key} - {kvp.Value.Price:f2}");
            }
        }
    }

    class Game 
    {
        public Game(string name, string dLC, double price)
        {
            this.Name = name;
            this.DLC = dLC;
            this.Price = price; 
        }

        public Game(string name,  double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }
        public string DLC { get; set; } = string.Empty;
        public double Price { get; set; }
      }
}

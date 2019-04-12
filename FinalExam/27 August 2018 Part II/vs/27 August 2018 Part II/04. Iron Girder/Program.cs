using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Iron_Girder
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = string.Empty;
            var dictTownTime = new Dictionary<string, int>();
            var dictTownPeople = new Dictionary<string, int>();
            while ((inputLine = Console.ReadLine()) != "Slide rule")
            {
                var commands = inputLine.Split(new string[] { ":", "->" }, StringSplitOptions.RemoveEmptyEntries);
                var town = commands[0];
                var countPeople = int.Parse(commands[2]);
                var timeOrAmbush = commands[1];
                if (timeOrAmbush != "ambush")
                {
                    var time = int.Parse(timeOrAmbush);
                    if (!dictTownPeople.ContainsKey(town))
                    {
                        dictTownPeople.Add(town, 0);
                        dictTownTime.Add(town, 0);
                    }
                    if (dictTownTime[town] > time || dictTownTime[town]==0)
                    {
                        dictTownTime[town] = time;
                    }
                  
                    dictTownPeople[town] += countPeople;
                }
                else if (dictTownPeople.ContainsKey(town))
                {

                    dictTownTime[town] = 0;
                    dictTownPeople[town] -= countPeople;

                    if (dictTownPeople[town] <= 0)
                    {
                        dictTownPeople.Remove(town);
                        dictTownTime.Remove(town);
                    }
                }

            }
            //print
            foreach (var kvp in dictTownTime.Where(x => x.Value > 0).OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> Time: {kvp.Value} -> Passengers: {dictTownPeople[kvp.Key]}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Concert_01._Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            var dictBandMember = new Dictionary<string, List<string>>();
            var dictBandTotalTime = new Dictionary<string, int>();
            while ((command = Console.ReadLine()) != "start of concert")
            {
                var splitCommand = command.Split("; ", StringSplitOptions.RemoveEmptyEntries);
                var firtCommand = splitCommand[0];
                var bandName = splitCommand[1];
                if (firtCommand == "Play")
                {
                    var timeToAdd = int.Parse(splitCommand[2]);
                    if (!dictBandTotalTime.ContainsKey(bandName))
                    {
                        dictBandTotalTime.Add(bandName, timeToAdd);
                    }
                    else
                    {
                        dictBandTotalTime[bandName] += timeToAdd;
                    }
                }
                else if (firtCommand == "Add")
                {
                    var bandMember = splitCommand[2].Split(", ", StringSplitOptions.RemoveEmptyEntries);
                    if (!dictBandMember.ContainsKey(bandName))
                    {
                        dictBandMember.Add(bandName, new List<string>());
                        for (int i = 0; i < bandMember.Length; i++)
                        {
                            var memberToAdd = bandMember[i];
                            if (!dictBandMember[bandName].Contains(memberToAdd))
                            {
                                dictBandMember[bandName].Add(memberToAdd);
                            }

                        }
                    }
                    else
                    {
                        for (int i = 0; i < bandMember.Length; i++)
                        {
                            var memberToAdd = bandMember[i];
                            if (!dictBandMember[bandName].Contains(memberToAdd))
                            {
                                dictBandMember[bandName].Add(memberToAdd);
                            }
                        }
                    }
                }

            }
            Console.WriteLine($"Total time: {dictBandTotalTime.Values.Sum()}");
            foreach (var kvp in dictBandTotalTime.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
            var grupPrintMember = Console.ReadLine();
            Console.WriteLine(grupPrintMember);
            foreach (var kvp in dictBandMember[grupPrintMember])
            {
                Console.WriteLine($"=> {kvp}");
            }
        }
    }
}

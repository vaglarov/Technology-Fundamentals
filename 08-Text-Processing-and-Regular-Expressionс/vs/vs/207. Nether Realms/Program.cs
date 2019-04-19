using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _207._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLint = Console.ReadLine();
            var inputNames = inputLint.Split(new char[] { ',',' ' },StringSplitOptions.RemoveEmptyEntries);
            var dictPlayer = new Dictionary<string, Dictionary<string,double>>();
            foreach (var name in inputNames)
            {
                var playerName = name;
                string patternHealt = @"[^\d+\-*/.]";
                var regexName = Regex.Matches(playerName, patternHealt);
                var healtPlayer = 0;
                foreach (Match charakter in regexName)
                {
                    var charString = charakter.ToString();
                    healtPlayer += (int)charString[0];
                }
                var patternDemage = @"[+-]?\d{1,}\.?\d{0,}|\*|\-";
                var demagePlayer = 0.0;
                var countMultiplication = 0;
                var countDivision = 0;
                var regexDemage = Regex.Matches(playerName, patternDemage);
                foreach (Match mach in regexDemage)
                {
                    if (mach.ToString()=="*")
                    {
                        countMultiplication++;
                    }
                    else if (mach.ToString() == "/")
                    {
                        countDivision++;
                    }
                    else
                    {
                    demagePlayer += double.Parse(mach.ToString());
                    }
                }
                if (countMultiplication!=0)
                {
                    for (int i = 1; i <= countMultiplication; i++)
                    {
                        demagePlayer *= 2;
                    }
                }
                if (countDivision!=0)
                {
                    for (int i = 1; i <= countDivision; i++)
                    {
                        demagePlayer /= 2.0;
                    }
                }
                if (!dictPlayer.ContainsKey(playerName))
                {
                    dictPlayer.Add(playerName, new Dictionary<string,double>());
                }
                dictPlayer[playerName].Add("healt",healtPlayer);
                dictPlayer[playerName].Add("demage",demagePlayer);
            }
            foreach (var kvp in dictPlayer.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value["healt"]:f0} health, {kvp.Value["demage"]:f2} damage");
            }
        }
    }
}

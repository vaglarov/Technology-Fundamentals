using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _109._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictPlanet = new Dictionary<string, List<string>>();
            dictPlanet.Add("A", new List<string>());
            dictPlanet.Add("D", new List<string>());

            int numberLine = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberLine; i++)
            {

                string inputLine = Console.ReadLine();
                string patternDecriptCode = @"([starSTAR])";
                var regexDecript = Regex.Matches(inputLine, patternDecriptCode);
                var codeDecript = (-1) * regexDecript.Count;
                string decriptInput = DecriptStringAddAsciiNumber(inputLine, codeDecript);
                string patternGroupDecript = @"(?<planetName>(?<=@)[A-Z][a-z]+)(?:[^@:!\->]*):(?<population>\d+)([!])(?<position>[AD])!(?:[^@:!\->]*)->(?<soljerCout>\d+)";
                var regexGroup = Regex.Matches(decriptInput, patternGroupDecript);
                // Add  Planet in Dictionary
                foreach (Match kvp in regexGroup)
                {
                    string atackedOrDestroy = kvp.Groups["position"].Value;
                    string planetName = kvp.Groups["planetName"].Value;
                    if (atackedOrDestroy=="A"&& !dictPlanet["A"].Contains(planetName))
                    {
                        dictPlanet[atackedOrDestroy].Add(planetName);
                    }
                    else if (atackedOrDestroy == "D"&&!dictPlanet["D"].Contains(planetName))
                    {
                        dictPlanet[atackedOrDestroy].Add(planetName);
                    }
                }
      
            }
                PrintResult(dictPlanet);
        }

        private static void PrintResult(Dictionary<string, List<string>> dictPlanet)
        {
            var numberAttaked = dictPlanet["A"].Count;
            Console.WriteLine($"Attacked planets: {numberAttaked}");
            if (numberAttaked>0)
            {
                foreach (var item in dictPlanet["A"].OrderBy(x=>x))
                {
                    Console.WriteLine($"-> {item}");
                }
            }
            var numberDestroy = dictPlanet["D"].Count;
            Console.WriteLine($"Destroyed planets: {numberDestroy}");
            if (numberDestroy > 0)
            {
                foreach (var item in dictPlanet["D"].OrderBy(x => x))
                {
                    Console.WriteLine($"-> {item}");
                }
            }
        }

        private static string DecriptStringAddAsciiNumber(string inputLine, int codeDecript)
        {
            var output = new StringBuilder();
            for (int i = 0; i < inputLine.Length; i++)
            {
                var chararter = inputLine[i] + codeDecript;
                output.Append((char)chararter);
            }
            return output.ToString();
        }
    }
}

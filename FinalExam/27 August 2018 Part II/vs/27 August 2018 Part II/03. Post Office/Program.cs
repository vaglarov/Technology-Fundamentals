using System;
using System.Text.RegularExpressions;

namespace _03._Post_Office
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|');
            var firstPart = input[0];
            var secondPart = input[1];
            var thirdPart = input[2];
            string patterFirstPart = @"([#$%*&])(?<UpperLetters>[A-Z]+)\1";
            string patternSecondPart = @"\d{2}:\d{2}";
            var upperLetter = Regex.Match(firstPart, patterFirstPart).Groups["UpperLetters"];
            var matchNumbers = Regex.Matches(secondPart, patternSecondPart);
            foreach (var matchSymbol in upperLetter.ToString())
            {
                int symbolFirstPart = matchSymbol;
                foreach (var match in matchNumbers)
                {
                    var matchSplit = match.ToString().Split(':');
                    var asciiSymbol = int.Parse(matchSplit[0]);
                    var numberSymbols = int.Parse(matchSplit[1]);
                    var symbolSecondPart = asciiSymbol;
                    if (symbolSecondPart==symbolFirstPart)
                    {
                        foreach (var item in thirdPart.Split())
                        {
                            if (item.StartsWith((char)symbolFirstPart)&&item.Length==numberSymbols+1)
                            {
                                Console.WriteLine(item);
                                break;
                            }
                            
                        }
                        break;
                    }
                }
            }
        }
    }
}

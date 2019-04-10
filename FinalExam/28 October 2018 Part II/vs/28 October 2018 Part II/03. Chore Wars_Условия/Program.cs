using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Chore_Wars_Условия
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            var dictTime = new Dictionary<string, int>();
            dictTime.Add("Doing the dishes", 0);
            dictTime.Add("Cleaning the house", 0);
            dictTime.Add("Doing the laundry", 0);

   
            while ((command = Console.ReadLine()) != "wife is happy")
            {
                string pattern = @"(?<dish><[a-z0-9]+>)|(?<cleaning>\[[A-Z0-9]+\])|(?<laundry>\{[^\s\t]+})";
                var resultRegex = Regex.Matches(command, pattern);
                foreach (Match match in resultRegex)
                {
                    if (match.Groups["dish"].Value!="")
                    {
                        var patternSmallLetters = @"[a-z]";
                        var stringWithLetters=match.Groups["dish"].Value;
                        stringWithLetters=stringWithLetters.TrimStart('<');
                        stringWithLetters = stringWithLetters.TrimEnd('>');
                        var resultTime = Regex.Replace(stringWithLetters, patternSmallLetters, "");
                        for (int i = 0; i < resultTime.Length; i++)
                        {
                            var digits = int.Parse(resultTime[i].ToString());
                        dictTime["Doing the dishes"] += digits;
                        }
                    }
                    else if (match.Groups["cleaning"].Value != "")
                    {
                        var patternOnlyDigits = @"[^\d]";
                        var stringWithLetters = match.Groups["cleaning"].Value;
                        var resultTime = Regex.Replace(stringWithLetters, patternOnlyDigits, "");
                        for (int i = 0; i < resultTime.Length; i++)
                        {
                            var digits = int.Parse(resultTime[i].ToString());
                        dictTime["Cleaning the house"] += digits;
                        }

                    }
                    else if (match.Groups["laundry"].Value != "")
                    {
                        var patternUpperLetters = @"[^\d]";
                        var stringWithLetters = match.Groups["laundry"].Value;
                        stringWithLetters = stringWithLetters.TrimStart('[');
                        stringWithLetters = stringWithLetters.TrimEnd(']');
                        var resultTime = Regex.Replace(stringWithLetters, patternUpperLetters, "");
                        for (int i = 0; i < resultTime.Length; i++)
                        {
                            var digits = int.Parse(resultTime[i].ToString());
                        dictTime["Doing the laundry"] += digits;
                        }
                    }
                }

               
            }
       
            Console.WriteLine($"Doing the dishes - {dictTime["Doing the dishes"]} min.");
            Console.WriteLine($"Cleaning the house - {dictTime["Cleaning the house"]} min.");
            Console.WriteLine($"Doing the laundry - {dictTime["Doing the laundry"]} min.");
            Console.WriteLine($"Total - {dictTime.Values.Sum()} min.");
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            while ((input=Console.ReadLine())!= "Last note")
            {
                string patternWithoutLenght = @"^(?<name>[A-z0-9!@#$?]+)=(?<lenght>\d+)<<(?<geo>.+)";
                if (Regex.IsMatch(input,patternWithoutLenght))
                {
                    var regexGroup = Regex.Matches(input, patternWithoutLenght);
                    foreach (Match match in regexGroup)
                    {
                        var decriptName = match.Groups["name"].Value;
                        var lenghtGeo = int.Parse(match.Groups["lenght"].Value);
                        var geo= match.Groups["geo"].Value;
                        if (geo.Length== lenghtGeo)
                        {
                            var patternDecript = @"[!@#$?]+";
                            var name = Regex.Replace(decriptName, patternDecript,"");
                            Console.WriteLine($"Coordinates found! {name} -> {geo}");
                        }
                        else
                        {
                            Console.WriteLine("Nothing found!");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }

            }
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace _008._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string pattern = @"(?<BGCode>[+395])(?<separator>[- ])(?<SFCode>[2])\2(?<aa>\d{3})\2(?<aaaa>\d{4})\b";
            var result = Regex.Matches(inputLine, pattern);
            foreach (Match match in result)
            {//+359 2 222 2222
                Console.Write($"+359{match.Groups["separator"].Value}" +
                    $"{match.Groups["SFCode"].Value}{match.Groups["separator"].Value}" +
                    $"{match.Groups["aa"].Value}{match.Groups["separator"].Value}" +
                    $"{match.Groups["aaaa"].Value},");
            }
        }
    }
}

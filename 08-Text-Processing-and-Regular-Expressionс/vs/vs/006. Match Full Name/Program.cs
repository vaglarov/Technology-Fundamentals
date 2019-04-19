using System;
using System.Text.RegularExpressions;

namespace _007._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineInputText = Console.ReadLine();
            string patternDate = @"\b[A-Z][a-z]+[\s{1}][A-Z][a-z]\w+";
            MatchCollection result = Regex.Matches(lineInputText, patternDate);
            foreach (var kvp in result)
            {
                Console.Write($"{kvp} ");
            }
            Console.WriteLine();

        }
    }
}
using System;
using System.Text.RegularExpressions;

namespace _108._Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine(); 
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            MatchCollection result = Regex.Matches(inputLine, pattern);
            foreach (Match item in result)
            {
                Console.Write($"{item.Value} ");
            }
            Console.WriteLine();
        }
    }
}

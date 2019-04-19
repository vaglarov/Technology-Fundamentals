using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _006._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineInputText = Console.ReadLine();
            string regexPattern = @"\b(?<day>[0-3][0-9])(?<sepchar>[-.,\/])(?<month>[A-Z][a-z][a-z])\2(?<yaer>\d{4})";
            MatchCollection result = Regex.Matches(lineInputText, regexPattern);
            //13/Jul/1928, 10-Nov-1934, , 01/Jan-1951,f 25.Dec.1937 23/09/1973, 1/Feb/2016
            foreach (Match kvp in result)
            {//Day: 10, Month: Nov, Year: 1934
                Console.Write($"Day: {kvp.Groups["day"].Value}, Month: {kvp.Groups["month"].Value}, Year: {kvp.Groups["yaer"].Value}");
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}


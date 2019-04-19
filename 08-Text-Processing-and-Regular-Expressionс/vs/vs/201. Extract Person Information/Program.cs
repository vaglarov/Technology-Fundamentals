using System;
using System.Text.RegularExpressions;

namespace _201._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLine = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberLine; i++)
            {
                string lineInput = Console.ReadLine();
                //string pattern = @"@(?<name>[A-z][a-z]*)\|.*#(?<age>[\d]*)\*";
                //var regexMatch = Regex.Matches(lineInput, pattern);
                //foreach (Match item in regexMatch)
                //{
                //    var name = item.Groups["name"].Value;
                //    var age = int.Parse(item.Groups["age"].Value);
                //    Console.WriteLine($"{name} is {age} years old."); //George is 18 years old.
                //}
                Regex namePattern = new Regex(@"@(?<name>[\S\s]*?)\|");
                //namePattern.Match(input).Groups["name"].ToString()
                Regex agePattern = new Regex(@"#(?<age>[\S\s]*?)\*");

                if (namePattern.IsMatch(lineInput) && agePattern.IsMatch(lineInput))
                {
                    string name = namePattern.Match(lineInput).Groups["name"].Value;
                    int age=int.Parse(agePattern.Match(lineInput).Groups["age"].Value);
                    Console.WriteLine($"{name} is {age} years old.");
                }


            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _110._Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var stringResult = new StringBuilder();
            var pattern = @"(?<word>\D+)(?<digits>\d+)";
            var result= Regex.Matches(inputLine, pattern);
            var unicCharakter = new HashSet<char>();
            foreach (Match item in result)
            {
                
                    string word = item.Groups["word"].Value.ToUpper();
                    int countTorepeat = int.Parse(item.Groups["digits"].Value);
                if (countTorepeat>0)
                {

                    for (int j = 0; j < word.Length; j++)
                    {
                        var charkter = item.Groups["word"].Value.ToUpper()[j];
                        if (!unicCharakter.Contains(charkter))
                        {
                            unicCharakter.Add(charkter);
                        }
                    }
                    for (int i = 0; i < countTorepeat; i++)
                    {
                    stringResult.Append(word);
                    }
                }
                
            }
           
            Console.WriteLine($"Unique symbols used: {unicCharakter.Count}");
            Console.WriteLine(stringResult);
        }
    }
}

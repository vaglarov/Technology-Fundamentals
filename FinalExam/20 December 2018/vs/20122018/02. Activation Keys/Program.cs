using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = new List<string>();
            var lineSplit = input.Split("&", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lineSplit.Length; i++)
            {
                var wordTocheck = lineSplit[i];
                var regexPattern = @"[^\dA-z]";
                var wordAfterReplaceDigits = string.Empty;
                if (!Regex.IsMatch(wordTocheck, regexPattern) && (wordTocheck.Length == 16 || wordTocheck.Length == 25))
                {
                    for (int j = 0; j < wordTocheck.Length; j++)
                    {
                        var character = (char)wordTocheck[j];
                        if (Char.IsDigit(character))
                        {
                            var resultDigit = (9 - int.Parse(character.ToString()));
                            character = (char)(48 + resultDigit);
                        }
                        wordAfterReplaceDigits += character;
                    }
                        var wordWitdAddDash = string.Empty;
                    if (wordAfterReplaceDigits.Length == 16)
                    {
                        var patternGroup = @"[\w\d]{4}";
                        MatchCollection resultMatch = Regex.Matches(wordAfterReplaceDigits, patternGroup);
                        foreach (Match kvp in resultMatch)
                        {
                            
                            wordWitdAddDash += kvp;
                            wordWitdAddDash += "-";
                        }
                        wordWitdAddDash = wordWitdAddDash.TrimEnd('-');
                    }
                    if (wordAfterReplaceDigits.Length == 25)
                    {
                        var patternGroup = @"[\w\d]{5}";
                        MatchCollection resultMatch = Regex.Matches(wordAfterReplaceDigits, patternGroup);
                        foreach (Match kvp in resultMatch)
                        {

                            wordWitdAddDash += kvp;
                            wordWitdAddDash += "-";
                        }
                        wordWitdAddDash = wordWitdAddDash.TrimEnd('-');
                    }
                    result.Add(wordWitdAddDash.ToUpper());
                }
            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}

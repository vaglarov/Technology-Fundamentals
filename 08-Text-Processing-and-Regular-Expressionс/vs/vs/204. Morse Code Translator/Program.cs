using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _204._Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string pattern = @"(?<word>[\. -]+)\s?(\|\s)?";
            var resultRegex = Regex.Matches(inputLine, pattern);
            var listLetter = new List<string>();
            foreach (Match item in resultRegex)
            {
                var wordDecript = item.Groups["word"].Value;
                string patternDecript = @"(?<char>[\.-]+)";
                var resultRegexWord = Regex.Matches(wordDecript, patternDecript);
                var buildWord =new  StringBuilder();
                foreach (Match charakter in resultRegexWord)
                {
                    var sing = charakter.Groups["char"].Value;
                    switch (sing)
                    {
                        case ".-":
                            sing = "A";
                            buildWord.Append(sing);
                            break;
                        case "-...":
                            sing = "B";
                            buildWord.Append(sing);
                            break;
                        case "-.-.":
                            sing = "C";
                            buildWord.Append(sing);
                            break;
                        case "-..":
                            sing = "D";
                            buildWord.Append(sing);

                            break;
                        case ".":
                            sing = "E";
                            buildWord.Append(sing);
                            break;
                        case "..-.":
                            sing = "F";
                            buildWord.Append(sing);
                            break;
                        case "--.":
                            sing = "G";
                            buildWord.Append(sing);
                            break;
                        case "....":
                            sing = "H";
                            buildWord.Append(sing);
                            break;
                        case "..":
                            sing = "I";
                            buildWord.Append(sing);
                            break;
                        case ".---":
                            sing = "J";
                            buildWord.Append(sing);
                            break;
                        case "-.-":
                            sing = "K";
                            buildWord.Append(sing);
                            break;
                        case ".-..":
                            sing = "L";
                            buildWord.Append(sing);
                            break;
                        case "--":
                            sing = "M";
                            buildWord.Append(sing);
                            break;
                        case "-.":
                            sing = "N";
                            buildWord.Append(sing);
                            break;
                        case "---":
                            sing = "O";
                            buildWord.Append(sing);
                            break;
                        case ".--.":
                            sing = "P";
                            buildWord.Append(sing);
                            break;
                        case "--.-":
                            sing = "Q";
                            buildWord.Append(sing);
                            break;
                        case ".-.":
                            sing = "R";
                            buildWord.Append(sing);
                            break;
                        case "...":
                            sing = "S";
                            buildWord.Append(sing);
                            break;
                        case "-":
                            sing = "T";
                            buildWord.Append(sing);
                            break;
                        case "..-":
                            sing = "U";
                            buildWord.Append(sing);
                            break;
                        case "...-":
                            sing = "V";
                            buildWord.Append(sing);
                            break;
                        case ".--":
                            sing = "W";
                            buildWord.Append(sing);
                            break;
                        case "-..-":
                            sing = "X";
                            buildWord.Append(sing);
                            break;
                        case "-.--":
                            sing = "Y";
                            buildWord.Append(sing);
                            break;
                        case "--..":
                            sing = "Z";
                            buildWord.Append(sing);
                            break;
                    }
                }
                    listLetter.Add(buildWord.ToString());
            }
            foreach (var word in listLetter)
            {
                Console.Write($"{word} ");
            }
        }
    }
}

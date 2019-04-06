using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _2_Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine();
            var secondLine = Console.ReadLine();
            var secondLineArr = secondLine.Split(' ');
            var stringMustChange = secondLineArr[0]; 
            var stringChange = secondLineArr[1];
            string patternRegex = @"[^d-z#\|{}]";
            if (Regex.IsMatch(firstLine, patternRegex))
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
            else
            {


                var newFirstLine = string.Empty;
                //create new line
                for (int i = 0; i < firstLine.Length; i++)
                {
                    var newChar = (int)firstLine[i] - 3;
                    newFirstLine += (char)newChar;
                }
                StringBuilder builder = new StringBuilder(newFirstLine);
                StringBuilder result = builder.Replace(stringMustChange, stringChange);
                Console.WriteLine(result);
            }
        }
    }
}

using System;
using System.Text.RegularExpressions;
using System.Text;


namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLine = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberLine; i++)
            {
                var lineInput = Console.ReadLine();
                string patternDecript = @"[starSTAR]";
                int codeDecript = Regex.Matches(lineInput, patternDecript).Count;
                var afterDecript = new StringBuilder();
                for (int j = 0; j < lineInput.Length; j++)
                {
                    var newChar = (char)(lineInput[j]-codeDecript);
                    afterDecript.Append(newChar);
                }
                string patternAll = @"@(?<planetName>[A-Z][a-z]+)([^@:!\->]*):(?<population>\d+)([^@:!\->]*)!(?<AD>[AD])!([^@:!\->]*)->\d+";
            }
        }
    }
}

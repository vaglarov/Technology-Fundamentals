using System;

namespace _103._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            PrintCharIsRange(firstChar, secondChar);
        }

        private static void PrintCharIsRange(char firstChar, char secondChar)
        {
            // Change First<-> Second if First is greater
            if (firstChar > secondChar)
            {
                char charTosecond = secondChar;
                secondChar = firstChar;
                firstChar = charTosecond;
            }
            for (char i = (char)(firstChar + 1); i < secondChar; i++)
            {
                if (i == secondChar - 1)
                {
                    Console.Write($"{i}");
                }
                else
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
    }
}

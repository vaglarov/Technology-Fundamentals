using System;
using System.Collections.Generic;

namespace _101._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var inputLine = Console.ReadLine();
            var dictChar = new Dictionary<char, int>();
            for (int i = 0; i < inputLine.Length; i++)
            {
                if (inputLine[i]!=' ')
                {
                    if (!dictChar.ContainsKey(inputLine[i]))
                    {
                        dictChar.Add(inputLine[i], 1);
                    }
                    else
                    {
                        dictChar[inputLine[i]]++;
                    }

                }
            }
            foreach (var item in dictChar)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

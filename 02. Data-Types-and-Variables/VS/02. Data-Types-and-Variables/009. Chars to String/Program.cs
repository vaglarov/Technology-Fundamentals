using System;

namespace _009._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] allChar = new char[3];
            for (int i = 0; i < 3; i++)
            {
                char sing = char.Parse(Console.ReadLine());
                allChar[i] = sing;
            }

            for (int i = 0; i < allChar.Length; i++)
            {
                Console.Write(allChar[i]);
            }
            Console.WriteLine();
        }
    }
}

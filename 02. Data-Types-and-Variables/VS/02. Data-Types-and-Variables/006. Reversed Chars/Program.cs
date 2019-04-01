using System;


namespace _006._Reversed_Chars
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
           
            for (int i = allChar.Length-1; i >= 0; i--)
            {
                Console.Write($"{allChar[i]} ");
            }
            Console.WriteLine();
        }
    }
}

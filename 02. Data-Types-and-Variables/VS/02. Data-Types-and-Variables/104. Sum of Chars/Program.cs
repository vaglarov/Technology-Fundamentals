using System;

namespace _104._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInputChar = int.Parse(Console.ReadLine());
            int sumOfASCIIdigits = 0;
            for (int i = 0; i < numberInputChar; i++)
            {
                char inputChar = char.Parse(Console.ReadLine());
                sumOfASCIIdigits += inputChar;
            }
            Console.WriteLine($"The sum equals: {sumOfASCIIdigits}");
        }
    }
}

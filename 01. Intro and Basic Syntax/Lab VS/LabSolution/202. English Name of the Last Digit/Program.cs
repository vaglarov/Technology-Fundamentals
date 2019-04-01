using System;

namespace _202._English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput=int.Parse(Console.ReadLine());
            string result =takeThatNumberAndReturnLastNumberLetter(numberInput);
            Console.WriteLine(result.ToLower());
        }

        private static string takeThatNumberAndReturnLastNumberLetter(int numberInput)
        {
            int lastLetter = numberInput % 10;
            string result = string.Empty;
            switch (lastLetter)
            {
                case 1: result = "One"; break;
                case 2: result = "Two"; break;
                case 3: result = "Three"; break;
                case 4: result = "Four"; break;
                case 5: result = "Five"; break;
                case 6: result = "Six"; break;
                case 7: result = "Seven"; break;
                case 8: result = "Eight"; break;
                case 9: result = "Nine"; break;
                case 0: result = "Zero"; break;
            }
            return result;
            
        }
    }
}

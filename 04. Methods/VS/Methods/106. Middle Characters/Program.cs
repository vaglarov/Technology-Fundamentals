using System;


namespace _106._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputText = Console.ReadLine();
            string middleString = MiddleStringInLine(inputText);
            Console.WriteLine(middleString);
        }

        private static string MiddleStringInLine(string text)
        {
            if (text.Length % 2 == 0)
            {
                int index = text.Length / 2-1;
              
                char middChar = text[index];
                char middChar1 = text[index + 1];
                string result = middChar.ToString() + middChar1.ToString();
                return result;
            }
            else
            {
                int index = text.Length / 2 ;
                char middChar = text[index];
                return middChar.ToString();
            }
        }
    }
}

using System;
using System.Globalization;

namespace _102._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string inputString = Console.ReadLine();
            int numberVowel = GetNumberVowels(inputString);
            Console.WriteLine(numberVowel);
        }

        private static int GetNumberVowels(string stringInput)
        {
            int numberVowel = default(int);
            stringInput=stringInput.ToLower();
            for (int i = 0; i < stringInput.Length; i++)
            {
                char charFromString = stringInput[i];
                if (    charFromString=='a'
                    || charFromString == 'e' 
                    || charFromString == 'i' 
                    || charFromString == 'o'
                    || charFromString == 'u'
                    || charFromString == 'y')
                {
                    numberVowel++;
                }
            }
            return numberVowel;
        }
    }
}

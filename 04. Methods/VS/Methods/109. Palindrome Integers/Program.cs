using System;
using System.Linq;
using System.Collections.Generic;

namespace _109._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineCommand = Console.ReadLine();
            while (lineCommand!="END")
            {
                int numberinput = int.Parse(lineCommand);
                bool result = CherNumberIsPalindrom(numberinput);
                Console.WriteLine(result.ToString().ToLower());
                lineCommand = Console.ReadLine();
            }
        }
        // 
        private static bool CherNumberIsPalindrom(int number)
        {
            List<int> numberInListLeftToRight = new List<int>();
            List<int> numberInListRightToLeft = new List<int>();

            while (number>0)
            {
                int LastDigits = number % 10;
                numberInListLeftToRight.Add(LastDigits);
                number /= 10;
            }
            numberInListRightToLeft = numberInListLeftToRight.ToList();
            numberInListRightToLeft.Reverse();

            for (int i = 0; i < numberInListLeftToRight.Count; i++)
            {
                if (numberInListLeftToRight[i]!=numberInListRightToLeft[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

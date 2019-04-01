using System;

namespace _012._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNumberInput = int.Parse(Console.ReadLine());
            for (int i = 1; i <= countNumberInput; i++)
            {
                bool IsSpecialNumber = false;
                int checkNumberForDigits = i;
                int sumDigits = 0;
                while (i > 0)
                {
                    sumDigits += i % 10;
                    i = i / 10;
                }
                if ((sumDigits == 5) || (sumDigits == 7) || (sumDigits == 11))
                {
                    IsSpecialNumber = true;
                }
                Console.WriteLine($"{checkNumberForDigits} -> {IsSpecialNumber}");
                i = checkNumberForDigits;
            }

        }
    }
}

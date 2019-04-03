using System;

namespace _110._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int endPeriod = int.Parse(Console.ReadLine());
            for (int i = 1; i <= endPeriod; i++)
            {
                bool isTopNumber = TopNumberChecher(i);
                if (isTopNumber)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool TopNumberChecher(int number)
        {
            int summDigits = default(int);
            int temp = number;
            bool haveOneOddDigits = false;
            while (temp>0)
            {
                int tempNumber= temp % 10;
                if (tempNumber%2==1)
                {
                    haveOneOddDigits = true;
                }
                summDigits += temp % 10;
                temp /= 10;
            }
            if (summDigits%8==0&& haveOneOddDigits)
            {
                return true;
            }
            return false;
        }
    }
}

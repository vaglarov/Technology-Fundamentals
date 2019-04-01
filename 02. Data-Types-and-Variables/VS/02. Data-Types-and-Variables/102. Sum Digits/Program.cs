using System;

namespace _102._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbereInput = int.Parse(Console.ReadLine());
            int sumDigits = 0;
            while (numbereInput > 0)
            {
                sumDigits += numbereInput % 10;
                numbereInput = numbereInput / 10;
            }
            Console.WriteLine(sumDigits);
        }
    }
}

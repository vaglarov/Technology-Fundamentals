using System;

namespace _107._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int pollCapacity = 255;
            int numbelLineFill = int.Parse(Console.ReadLine());
            int sumFillWather = 0;
            for (int i = 0; i < numbelLineFill; i++)
            {
                int fillWather = int.Parse(Console.ReadLine());
                sumFillWather += fillWather;
                if (sumFillWather>pollCapacity)
                {
                    sumFillWather -= fillWather;
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(sumFillWather);
        }
    }
}

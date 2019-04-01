using System;

namespace _001._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meterInput = int.Parse(Console.ReadLine());
            double distanceToKilometer = meterInput / 1000.00;
            Console.WriteLine($"{distanceToKilometer:f2}");
        }
    }
}

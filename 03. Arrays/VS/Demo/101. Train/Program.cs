using System;
using System.Linq;

namespace _101._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberWagons = int.Parse(Console.ReadLine());
            var pepoleInWagons = new int[numberWagons];
            for (int i = 0; i < pepoleInWagons.Length; i++)
            {
                pepoleInWagons[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(' ',pepoleInWagons));
            Console.WriteLine($"{pepoleInWagons.Sum()}");
        }
    }
}

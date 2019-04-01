using System;
using System.Collections.Generic;
using System.Linq;

namespace _108._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, string> dictKent = new SortedDictionary<double, string>();
            int numbersTypeKen = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbersTypeKen; i++)
            {
                string typeKen = Console.ReadLine();
                double radiusKen = double.Parse(Console.ReadLine());
                int heightKen = int.Parse(Console.ReadLine());
                //π * r^2 * h
                double volumeKen = Math.PI*Math.Pow(radiusKen,2)*heightKen;
                dictKent.Add(volumeKen, typeKen);
            }
            string result = dictKent.Values.Last();
            Console.WriteLine(result);
        }
    }
}

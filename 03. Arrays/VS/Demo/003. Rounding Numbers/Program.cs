using System;
using System.Linq;

namespace _003._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var floatingPointArrInput = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            for (int i = 0; i < floatingPointArrInput.Length; i++)
            {
                Console.WriteLine($"{floatingPointArrInput[i]} => {Math.Round(floatingPointArrInput[i],MidpointRounding.AwayFromZero)}");
            }
        }
    }
}

using System;
using System.Linq;

namespace _006._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersAllArrInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var sumEvenFromArr = numbersAllArrInput.Where(x => x % 2 == 0).Sum();
            var sumOddFromArr = numbersAllArrInput.Where(x => x % 2 == 1).Sum();
            Console.WriteLine(sumEvenFromArr-sumOddFromArr);
        }
    }
}

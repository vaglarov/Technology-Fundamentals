using System;
using System.Linq;

namespace _007._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firsArrInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondArrInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var isEqual = firsArrInput.SequenceEqual(secondArrInput);
            if (isEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {firsArrInput.Sum()}");
            }
            else
            {
                for (int i = 0; i < firsArrInput.Length; i++)
                {
                    if (firsArrInput[i]!=secondArrInput[i])
                    {
                        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                        break;
                    }
                }
            }
        }
    }
}

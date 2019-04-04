using System;
using System.Collections.Generic;
using System.Linq;

namespace _105.bombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
       List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bomb = input[0];
            int power = input[1];
            int indexOfBomb = default(int);
            int indexToRemoveFrom = default(int);

            while (true)
            {
                if (!sequence.Contains(bomb))
                {
                    break;
                }

                indexOfBomb = sequence.IndexOf(bomb);
                indexToRemoveFrom = Math.Max(0, indexOfBomb - power);

                for (int i = 0; i < 1 + 2 * power; i++)
                {
                    sequence.RemoveAt(indexToRemoveFrom);

                    if (indexToRemoveFrom >= sequence.Count)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(sequence.Sum());
        }
    }
}
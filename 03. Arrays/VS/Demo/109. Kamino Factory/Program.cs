using System;
using System.Collections.Generic;
using System.Linq;

namespace _109._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());//i will use list Tish row is parasit
            string command = Console.ReadLine();
            var bestList = new List<int>();
            var longestSequnce = -1;
            var longestIndex = 0;
            int longestSubSum = -1;
            int longestCount = -1;
            int countCurrent = 0;
            while (command != "Clone them!")
            {
                var currentLinst = command.Split('!', StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToList();
                countCurrent++;
                var sequnce = -1;
                var index = 0;
                int subSum = currentLinst.Sum();
                int count = 0;
                for (int i = 0; i < currentLinst.Count; i++)
                {
                    if (currentLinst[i] == 1)
                    {
                        count++;
                        if (count > sequnce)
                        {
                            sequnce = count;
                            index = i - count;
                        }
                    }
                    else
                    {
                        count = 0;
                    }

                }
                if (sequnce > longestSequnce)
                {
                    longestIndex = index;
                    longestSequnce = sequnce;
                    longestCount = countCurrent;
                    longestSubSum = subSum;
                    bestList = currentLinst.ToList();
                }
                else if (sequnce == longestSequnce && longestIndex > index)
                {
                    longestCount = countCurrent;
                    longestIndex = index;
                    longestSequnce = sequnce;
                    longestSubSum = subSum;
                    bestList = currentLinst.ToList();
                }
                else if (sequnce == longestSequnce && longestIndex == index && longestSubSum < subSum)
                {
                    longestCount = countCurrent;
                    longestSubSum = subSum;
                    bestList = currentLinst.ToList();
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {longestCount} with sum: {longestSubSum}.");
            Console.WriteLine(string.Join(' ', bestList));
        }
    }
}

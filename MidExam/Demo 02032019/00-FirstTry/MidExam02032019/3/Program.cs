using System;
using System.Collections.Generic;
using System.Linq;


namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var bestList = new List<int>();
            int sum = int.MinValue;
            double averQuantit = default(double);
            while (line != "Bake It!")
            {
                var newList = line.Split("#").Select(int.Parse).ToList();
                var newSum = newList.Sum();
                var newAvrQuanti = newSum / (double)newList.Count;
                if (newSum > sum)
                {
                    RefillBesttList(bestList, newList);
                    sum = bestList.Sum();
                    averQuantit = sum / (double)bestList.Count;

                }
                else if (newSum == sum)
                {
                    if (averQuantit < newAvrQuanti)
                    {
                        RefillBesttList(bestList, newList);
                        sum = bestList.Sum();
                        averQuantit = sum / (double)bestList.Count;
                    }

                    else if (bestList.Count > newList.Count && averQuantit == newAvrQuanti)
                    {
                        RefillBesttList(bestList, newList);
                        sum = bestList.Sum();
                        averQuantit = sum / (double)bestList.Count;
                    }
                }

                line = Console.ReadLine();
            }
            if (bestList.Count != 0)
            {
                Console.WriteLine($"Best Batch quality: {sum}");
                Console.WriteLine(string.Join(" ", bestList));
            }
        }

        private static void RefillBesttList(List<int> bestList, List<int> newList)
        {
            bestList.Clear();
            foreach (var item in newList)
            {
                bestList.Add(item);
            }
        }
    }
}
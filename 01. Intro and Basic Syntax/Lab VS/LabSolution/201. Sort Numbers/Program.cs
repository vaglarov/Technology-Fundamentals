using System;
using System.Collections.Generic;
using System.Linq;

namespace _201._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collectionFromInt = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                collectionFromInt.Add(int.Parse(Console.ReadLine()));

            }
            collectionFromInt.Sort();
            for (int i = collectionFromInt.Count-1; i >=0; i--)
            {
                Console.WriteLine(collectionFromInt[i]);
            }
        }
    }
}

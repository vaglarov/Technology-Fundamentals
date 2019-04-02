using System;
using System.Linq;
using System.Collections.Generic;

namespace _104._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int numberRotation = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberRotation; i++)
            {
                int firtElementInList = numbers[0];
                for (int j = 0; j < numbers.Count-1; j++)
                {
                    int a = numbers[j + 1];
                    numbers[j]=a;
                }
                numbers[numbers.Count - 1] = firtElementInList;
            }
            Console.WriteLine(string.Join(' ',numbers));
        }
    }
}

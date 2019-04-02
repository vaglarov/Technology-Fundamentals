using System;
using System.Linq;
using System.Collections.Generic;


namespace _103._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberRowInput = int.Parse(Console.ReadLine());
            List<int> firsList = new List<int>();
            List<int> secondList = new List<int>();
            for (int i = 1; i <= numberRowInput; i++)
            {
                var numberArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (i%2==1)
                {
                    firsList.Add(numberArr[0]);
                    secondList.Add(numberArr[1]);
                }
                else
                {
                    firsList.Add(numberArr[1]);
                    secondList.Add(numberArr[0]);
                }
            }
            Console.WriteLine(string.Join(' ',firsList));
            Console.WriteLine(string.Join(' ',secondList));
        }
    }
}

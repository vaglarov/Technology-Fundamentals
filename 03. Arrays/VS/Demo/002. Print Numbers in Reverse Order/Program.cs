using System;
using System.Linq;
using System.Collections.Generic;

namespace _002._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInArrInput = int.Parse(Console.ReadLine());
            var numbersArr = new int[numberInArrInput];
            for (int i = 0; i < numbersArr.Length; i++)
            {
                numbersArr[i] = int.Parse(Console.ReadLine());
            }
            var arrToList = numbersArr.ToList();
           //arrToList.Sort();
            arrToList.Reverse();
            Console.WriteLine(string.Join(" ",arrToList));

        }
    }
}

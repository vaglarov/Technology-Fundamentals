using System;
using System.Collections.Generic;
using System.Linq;

namespace _106._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
       
            List<int> listBeforeMiddle = new List<int>();
            List<int> listAfterMiddle = new List<int>(numbersInput);
            int result = 0;
            bool isMatch = false;
            for (int i = 0; i < numbersInput.Count; i++)
            {
                listAfterMiddle.RemoveAt(0);
                if (listBeforeMiddle.Sum() == listAfterMiddle.Sum())
                {
                    result = i;
                    isMatch = true;
                    break;
                }
                listBeforeMiddle.Add(numbersInput[i]);
            }
            if (isMatch)
            {
            Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("no");
            }
        }

    }
}


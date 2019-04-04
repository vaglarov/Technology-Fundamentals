using System;
using System.Collections.Generic;
using System.Linq;

namespace _108._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            var listNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();
            string tekst = Console.ReadLine();
            var listResult = new List<char>();
            for (int i = 0; i < listNumbers.Count; i++)
            {
                var sumDigits = 0;
                var number = listNumbers[i];
                while (number>0)
                {
                    var lastDigits = number % 10;
                    number /= 10;
                    sumDigits += lastDigits;
                }
                var index = 0;
                if (sumDigits>tekst.Length)
                {
                    index = sumDigits % tekst.Length;
                }
                else
                {
                    index = sumDigits+1;
                }
                var takeChar=(char)0;
                for (int j = 0; j < tekst.Length; j++)
                {
                    if (j==takeChar)
                    {
                        takeChar = tekst[i];
                        break;
                    }
                }
                listResult.Add(takeChar);
            
            }
            Console.WriteLine(string.Join("",listResult));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArrayBefore = Console.ReadLine()
             .Split(' ')
             .Select(int.Parse)
             .ToArray();
            int[] condensed = new int[numbersArrayBefore.Length - 1];
            while (numbersArrayBefore.Length > 1)
            {
                for (int i = 0; i < numbersArrayBefore.Length - 1; i++)
                {
                    condensed[i] = numbersArrayBefore[i] + numbersArrayBefore[i + 1];
                    numbersArrayBefore[i] = condensed[i];
                }
                Array.Resize(ref condensed, condensed.Length - 1);
                Array.Resize(ref numbersArrayBefore, numbersArrayBefore.Length - 1);
            }
            Console.WriteLine(numbersArrayBefore[0]);
        }
    }
}

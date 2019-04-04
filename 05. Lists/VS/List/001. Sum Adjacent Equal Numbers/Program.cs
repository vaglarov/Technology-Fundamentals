using System;
using System.Linq;

namespace _001._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var listInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();
            for (int i = 0; i < listInput.Count-1; i++)
            {
                if (listInput[i]==listInput[i+1])
                {
                    var newNumber = listInput[i] + listInput[i + 1];
                    listInput.RemoveAt(i);
                    listInput.RemoveAt(i);
                    listInput.Insert(i, newNumber);
                    i=-1;
                }
            }
            Console.WriteLine(string.Join(' ', listInput));

        }
    }
}

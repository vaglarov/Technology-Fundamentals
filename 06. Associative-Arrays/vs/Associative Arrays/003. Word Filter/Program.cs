using System;
using System.Linq;

namespace _003._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var lineInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length % 2 == 0).ToList();
            Console.WriteLine(string.Join(Environment.NewLine,lineInput));
        }
    }
}

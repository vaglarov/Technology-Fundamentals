using System;
using System.Linq;

namespace _004._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var lineInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                 .OrderByDescending(x => x).Take(3).ToList();
            Console.WriteLine(string.Join(' ',lineInput));
        }
    }
}

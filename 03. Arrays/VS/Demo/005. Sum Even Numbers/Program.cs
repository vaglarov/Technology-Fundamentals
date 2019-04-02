using System;
using System.Linq;

namespace _005._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrFromEven = Console.ReadLine().Split(' ').Select(int.Parse).Where(x => x % 2 == 0).ToArray();
            var sum = arrFromEven.Sum();
            Console.WriteLine(sum);
        }
    }
}

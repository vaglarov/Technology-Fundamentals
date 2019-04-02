using System;
using System.Linq;

namespace _004._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrOfStringsInput = Console.ReadLine().Split(' ').ToArray();
            Console.WriteLine(string.Join(' ', arrOfStringsInput.Reverse()));
        }
    }
}

using System;
using System.Collections;
using System.Linq;

namespace _204._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string commandInput = Console.ReadLine();
            string reversedCommand = new string(commandInput.Reverse().ToArray());
            Console.WriteLine(reversedCommand);
        }
    }
}

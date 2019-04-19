using System;
using System.Text;

namespace _104._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            var output = new StringBuilder();
            for (int i = 0; i < inputLine.Length; i++)
            {
                var chararter = inputLine[i]+3;
                output.Append((char)chararter);
            }
            Console.WriteLine(output);
        }
    }
}

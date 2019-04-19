using System;

namespace _001._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            while ((command=Console.ReadLine())!="end")
            {
                string reversedWord = string.Empty;
                for (int i = command.Length - 1; i >= 0; i--)
                {//chAir = riAhc
                    reversedWord += command[i];
                }
                Console.WriteLine($"{command} = {reversedWord}");
            }
        }
    }
}

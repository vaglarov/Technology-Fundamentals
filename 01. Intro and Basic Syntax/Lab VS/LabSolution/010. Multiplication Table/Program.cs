using System;

namespace _010._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToMakeTable = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int result = numberToMakeTable * i;
                Console.WriteLine($"{numberToMakeTable} X {i} = {result}");
            }
        }
    }
}

using System;

namespace _002._Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double gradeToPast = double.Parse(Console.ReadLine());
            if (gradeToPast>=3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}

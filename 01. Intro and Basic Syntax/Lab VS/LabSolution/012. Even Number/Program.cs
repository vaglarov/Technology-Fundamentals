using System;

namespace _012._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            while (numberInput%2!=0)
            {
                Console.WriteLine("Please write an even number.");
                numberInput = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {Math.Abs(numberInput)}");
        }
    }
}

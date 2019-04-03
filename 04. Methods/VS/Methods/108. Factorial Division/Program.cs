using System;

namespace _108._Factorial_Division
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            double result = CalculeteFacturiel(firstNumber) / CalculeteFacturiel(secondNumber);
            Console.WriteLine($"{result:f2}");

        }

        private static double CalculeteFacturiel(int number)
        {
          double result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}

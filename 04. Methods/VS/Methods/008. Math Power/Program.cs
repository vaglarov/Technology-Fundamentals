using System;

namespace _008._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor= ConsoleColor.DarkRed;
            double numberToBePowe = double.Parse(Console.ReadLine());
            double powerCoeficent = double.Parse(Console.ReadLine());
            double result = PowerNumber(numberToBePowe, powerCoeficent);
            Console.WriteLine(result);
        }

        static double PowerNumber(double number, double powerCoeficent)
        {
            double result = number;
            for (int i = 1; i < powerCoeficent; i++)
            {
                result *= number;
            }
            return  result;
        }
    }
}

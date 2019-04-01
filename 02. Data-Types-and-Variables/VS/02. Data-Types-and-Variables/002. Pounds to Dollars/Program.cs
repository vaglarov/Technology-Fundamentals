using System;

namespace _002._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double britishPoundInput = double.Parse(Console.ReadLine());
            double changeCoeficient = 1.31;
            double toUSDolar = britishPoundInput * changeCoeficient;
            Console.WriteLine($"{toUSDolar:f3}");
        }
    }
}

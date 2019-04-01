using System;

namespace _203._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumberInput = double.Parse(Console.ReadLine());
            double secondNumberInput = double.Parse(Console.ReadLine());
            bool isEqual = false; //                              1000000
            double result = Math.Abs(1000000 * firstNumberInput - 1000000*secondNumberInput);
            if (result< 1.0000)
            {
                isEqual = true;
            }
           
            Console.WriteLine(isEqual);
        }
    }
}

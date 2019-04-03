using System;

namespace _105._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int firstNumberInput = int.Parse(Console.ReadLine());
            int secondNumberInput = int.Parse(Console.ReadLine());
            int thirdNumberInput = int.Parse(Console.ReadLine());
            int sumFirstSecond = Sum(firstNumberInput, secondNumberInput);
            int substractSumThird= Substract(sumFirstSecond, thirdNumberInput);
            Console.WriteLine(substractSumThird);

        }

        private static int Substract(int substractForm, int number)
        {
            return substractForm - number;
        }

        private static int Sum(int first, int second)
        {
            return first + second;
        }
    }
}

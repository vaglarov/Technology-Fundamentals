using System;

namespace _011._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int firstNumber = int.Parse(Console.ReadLine());
            char calculateSing = char.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            double result = Calculate(firstNumber, calculateSing, secondNumber);
            Console.WriteLine($"{result:F0}");
        }

        private static double Calculate(int firstNumber, char calculateSing, int secondNumber)
        {
            double result = default(double);
            switch (calculateSing)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    result = firstNumber / secondNumber;
                    break;
            }
            return result;
        }
    }
}

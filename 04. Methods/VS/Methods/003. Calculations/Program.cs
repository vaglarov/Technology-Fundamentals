using System;

namespace _003._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string commandCalculation = Console.ReadLine();
            double firstNumberInput = double.Parse(Console.ReadLine());
            double secondNumberInput = double.Parse(Console.ReadLine());
            double result = default(double);
            switch (commandCalculation)
            {
                case "add":
                    result =Add(firstNumberInput,secondNumberInput);
                    break;
                case "multiply":
                    result = Multiply(firstNumberInput, secondNumberInput);
                    break;
                case "subtract":
                    result = Substract(firstNumberInput, secondNumberInput);
                    break;
                case "divide":
                    result = Divide(firstNumberInput, secondNumberInput);
                    break;
                default:
                    break;
            }
            PrintResult(result);
        }

        private static double Divide(double firstNumberInput, double secondNumberInput)
        {
            var result = firstNumberInput / secondNumberInput;
            return result;
        }

        private static double Substract(double firstNumber, double secondNumber)
        {
            var result = firstNumber - secondNumber;
            return result;
        }

        private static double Multiply(double firstNumber, double secondNumber)
        {
            var result = firstNumber * secondNumber;
            return result;
        }

        private static double Add(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            return result;
        }

        private static void PrintResult(double result)
        {
            Console.WriteLine(result);
        }
    }
}

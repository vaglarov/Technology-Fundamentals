using System;

namespace _009._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeCompare = Console.ReadLine();
            switch (typeCompare)
            {
                case "int":
                    int firstNumber = int.Parse(Console.ReadLine());
                    int secondNumber = int.Parse(Console.ReadLine());
                    var resultInt = GetMax(firstNumber, secondNumber);
                    Console.WriteLine(resultInt);
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    var resultSting = GetMax(firstString, secondString);
                    Console.WriteLine(resultSting);
                    break;
                case "char":
                    char firstChar =char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    var resultChar = GetMax(firstChar, secondChar);
                    Console.WriteLine(resultChar);
                    break;
            }
        }

        private static string GetMax(string first, string second)
        {

            int comparison = first.CompareTo(second);
            if (comparison > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        private static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber>=secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }

        private static char GetMax(char first, char second)
        {

            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}

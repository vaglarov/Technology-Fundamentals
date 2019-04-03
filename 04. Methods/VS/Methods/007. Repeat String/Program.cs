using System;

namespace _007._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToBeRepeated = Console.ReadLine();
            int numberOfRepeated = int.Parse(Console.ReadLine());
            string result = StringToBeRepeated(numberOfRepeated, stringToBeRepeated);
            Console.WriteLine(result);

        }

        private static string StringToBeRepeated(int numberOfRepeated, string stringToBeRepeated)
        {
            string result = string.Empty;
            for (int i = 0; i < numberOfRepeated; i++)
            {
                result = result + stringToBeRepeated;
            }
            return result;
        }
    }
}

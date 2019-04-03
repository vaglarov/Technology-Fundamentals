using System;

class Program
{
    static void Main(string[] args)
    {
        int inputNumber = int.Parse(Console.ReadLine());
        PrintNumberWithSing(inputNumber);
    }

    private static void PrintNumberWithSing(int number)
    {
        if (number==0)
        {
            Console.WriteLine("The number 0 is zero.");
        }
        else if (number>0)
        {
            Console.WriteLine($"The number {number} is positive.");
        }
        else if (number<0)
        {
            Console.WriteLine($"The number {number} is negative.");
        }
    }
}


using System;

namespace _104._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumberInput = int.Parse(Console.ReadLine());
            int endNumberInput = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = startNumberInput; i <=endNumberInput; i++)
            {
                sum += i;
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}

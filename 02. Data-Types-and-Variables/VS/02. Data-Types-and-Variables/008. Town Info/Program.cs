using System;

namespace _008._Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commandIput = new string[3];
            for (int i = 0; i < 3; i++)
            {
                commandIput[i] = Console.ReadLine();
            }
            Console.WriteLine($"Town {commandIput[0]} has population of " +
                $"{commandIput[1]} and area {commandIput[2]} square km.");
        }
    }
}

using System;

namespace _05._Month_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumberMonth = int.Parse(Console.ReadLine());
            if (inputNumberMonth < 1 || inputNumberMonth > 12)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                DateTime month = new DateTime(1900,inputNumberMonth,1);
            Console.WriteLine(month.ToString("MMMMMMMMMM"));
            }
        }
    }
}

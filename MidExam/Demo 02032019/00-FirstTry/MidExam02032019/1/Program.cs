using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
      //read data
            Console.ForegroundColor = ConsoleColor.Yellow;
            double budget = double.Parse(Console.ReadLine());
            int numberStudents = int.Parse(Console.ReadLine());
            double priceFlourForPakage = double.Parse(Console.ReadLine());
            double priceEggSingle = double.Parse(Console.ReadLine());
            double priceApron = double.Parse(Console.ReadLine());


            double neededMoney =Math.Ceiling( numberStudents*1.2) * priceApron+
           numberStudents * priceEggSingle * 10+
            numberStudents * priceFlourForPakage-
            (numberStudents / 5) * priceFlourForPakage;

            if (neededMoney<=budget)
            {
                Console.WriteLine($"Items purchased for {neededMoney:f2}$.");
            }
            else
            {
                Console.WriteLine($"{(neededMoney-budget):f2}$ more needed.");
            }
           
        }
    }
}

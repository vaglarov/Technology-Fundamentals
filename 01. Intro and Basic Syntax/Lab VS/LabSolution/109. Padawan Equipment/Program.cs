using System;

namespace _109._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amoountMoneyInput = double.Parse(Console.ReadLine());
            int numberOfStudentsInput = int.Parse(Console.ReadLine()); 
            double priceOfLightsabersInput = double.Parse(Console.ReadLine()); //must by 10%more
            double priceOfRobesInput = double.Parse(Console.ReadLine());
            double priceOfBeltInput = double.Parse(Console.ReadLine()); // every 6th is free
            double neededMoney = 0;
            double moneyForLightsabers =Math.Ceiling(numberOfStudentsInput*1.10) * priceOfLightsabersInput;
            double moneyForRobes = numberOfStudentsInput * priceOfRobesInput;
            double moneyForBelt = numberOfStudentsInput * priceOfBeltInput - 
                (priceOfBeltInput* (Math.Abs( numberOfStudentsInput /6)));
            neededMoney = moneyForLightsabers + moneyForRobes + moneyForBelt;
            if (neededMoney> amoountMoneyInput)
            {
                Console.WriteLine($"Ivan Cho will need {(neededMoney-amoountMoneyInput):f2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {neededMoney:f2}lv.");
            }
        }
    }
}

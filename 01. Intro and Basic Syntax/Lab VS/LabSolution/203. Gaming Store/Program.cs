using System;

namespace _203._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyInput = double.Parse(Console.ReadLine());
            string commandInput = Console.ReadLine();
            double price = 0;
            double spendMoney = 0;
            bool moneyIsZero = false;
            while (commandInput != "Game Time" && moneyInput > 0)
            {
                bool isFound = true;
                switch (commandInput)
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;

                    default:
                        isFound = false;
                        break;
                }
                if (moneyInput>=price&&isFound)
                {
                    Console.WriteLine($"Bought {commandInput}");
                    moneyInput -= price;
                    spendMoney += price;
                }
                else if (moneyInput<price&&isFound)
                {
                    Console.WriteLine("Too Expensive");
                }
                else if (isFound==false)
                {
                    Console.WriteLine("Not Found");
                }
                if (moneyInput<=0)
                {
                    Console.WriteLine("Out of money!");
                    moneyIsZero = true;
                    //break;
                }
                commandInput = Console.ReadLine();
            }
            if (moneyIsZero==false)
            {
                Console.WriteLine($"Total spent: ${spendMoney:f2}. Remaining: ${moneyInput:f2}");
            }
        }
    }
}

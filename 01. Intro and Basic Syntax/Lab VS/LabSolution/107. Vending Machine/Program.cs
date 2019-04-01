using System;

namespace _107._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double moneyInMachine = 0;
            bool canBuy = true;
            while (command!="Start")
            {
                double addCoin = double.Parse(command);
                if (addCoin==0.1||
                    addCoin == 0.2 ||
                    addCoin == 0.5 ||
                    addCoin == 1.0 ||
                    addCoin == 2.0)
                {
                    moneyInMachine += addCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {addCoin}");
                }
                command = Console.ReadLine();
            }
                command = Console.ReadLine();
            while (command!="End")
            {
                double priceProduct = 0;
                switch (command)
                {
                    case "Nuts":
                        priceProduct = 2.0;
                        break;
                    case "Water":
                        priceProduct = 0.7;
                        break;
                    case "Crisps":
                        priceProduct = 1.5;
                        break;
                    case "Soda":
                        priceProduct = 0.8;
                        break;
                    case "Coke":
                        priceProduct = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        canBuy = false;
                        break;
                }
                if (priceProduct>moneyInMachine&&canBuy)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else if(priceProduct <= moneyInMachine && canBuy)
                {
                    moneyInMachine = moneyInMachine - priceProduct;
                    Console.WriteLine($"Purchased {command.ToLower()}");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Change: {moneyInMachine:f2}");
        }
    }
}

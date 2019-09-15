using System;
using System.Linq;
using System.Collections.Generic;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = 100;
            int coins = 100;
            //ReadData
            string line = Console.ReadLine();
            //rest-2|order-10|eggs-100|rest-10
            var command = line.Split("|", StringSplitOptions.RemoveEmptyEntries);
            while (true)
            {
                for (int i = 0; i < command.Length; i++)
                {
                    var commandSmall = command[i].Split("-", StringSplitOptions.RemoveEmptyEntries);
                    //rest
                    switch (commandSmall[0])
                    {
                        case "rest":
                            var energyToAdd = int.Parse(commandSmall[1]);
                            if (energy == 100)
                            {
                                Console.WriteLine("You gained 0 energy.");
                                Console.WriteLine("Current energy: 100.");
                            }
                            else if ((energy + energyToAdd) > 100)
                            {
                                Console.WriteLine($"You gained {100 - energy} energy.");
                                Console.WriteLine("Current energy: 100.");
                                energy = 100;

                            }
                            else
                            {
                                energy += energyToAdd;
                                Console.WriteLine($"You gained {energyToAdd} energy.");
                                Console.WriteLine($"Current energy: {energy}.");
                            }
                            break;
                        case "order":
                            if (energy >= 30)
                            {
                                var earnCoins = int.Parse(commandSmall[1]);
                                Console.WriteLine($"You earned {earnCoins} coins.");
                                coins += earnCoins;
                                energy -= 30;
                            }
                            else
                            {
                                Console.WriteLine($"You had to rest!");
                                energy += 50;
                                //Console.WriteLine("Closed! Cannot afford oven.");
                                //break;
                            }
                            break;
                        default:
                            var product = commandSmall[0];
                            var priceProduct = int.Parse(commandSmall[1]);
                            if (coins > priceProduct)
                            {
                                Console.WriteLine($"You bought {product}.");
                                coins -= priceProduct;
                             
                            }
                            else
                            {
                                Console.WriteLine($"Closed! Cannot afford {product}.");
                                return;
                                break;

                            }

                            break;
                    }
                }

                Console.WriteLine("Day completed!");
                Console.WriteLine($"Coins: {coins}");
                Console.WriteLine($"Energy: {energy}");
                break;
            }


        }
    }
}

using System;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            //            10@10@10@2
            //Jump 1
            //Jump 2
            //Merry Xmas!
            Console.ForegroundColor = ConsoleColor.Yellow;
            var listHouses = Console.ReadLine().Split("@", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToList();
            string command = Console.ReadLine();
            var currentIndex = 0;
            while (command!= "Merry Xmas!")
            {
                var jumpCommand = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var jump = int.Parse(jumpCommand[1]);
                currentIndex = (jump + currentIndex) % listHouses.Count;
                if (listHouses[currentIndex]==0)
                {
                    Console.WriteLine($"House {currentIndex} will have a Merry Christmas.");
                }
                else
                {
                    var oldValue = listHouses[currentIndex] - 2;
                    listHouses[currentIndex] = oldValue;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Santa's last position was {currentIndex}.");
            int countFaildHouse = 0;
            foreach (var item in listHouses)
            {
                if (item!=0)
                {
                    countFaildHouse++;
                }
            }
            if (countFaildHouse==0)
            {
                Console.WriteLine($"Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Santa has failed {countFaildHouse} houses.");
            }
        }
    }
}

using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            //           •	On the 1st line, you are going to receive the days of the adventure – an integer in the range[1…100]
            //•	On the 2nd line – the count of players – an integer in the range[0 – 1000]
            //•	On the 3rd line -the group’s energy – a real number in the range[1 - 50000]
            //•	On the 4th line – water per day for one person – a real number[0.00 – 1000.00]
            //•	On the 5th line – food per day for one person – a real number[0.00 – 1000.00]
            //•	On the next n lines – one for each of the days – the amount of energy loss– a real number in the range[0.00 - 1000]
            //•	You will always have enough food and water.

            int dayesAdventure = int.Parse(Console.ReadLine());
            int numberPlayers = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double watherPerDayForOne = double.Parse(Console.ReadLine());
            double foodPerDayForOne = double.Parse(Console.ReadLine());
            bool haveEnergy = true;

            double totalWather = dayesAdventure * numberPlayers * watherPerDayForOne;
            double totalFood = dayesAdventure * numberPlayers * foodPerDayForOne;
            for (int i = 1; i <= dayesAdventure; i++)
            {
                double lostEnergy = double.Parse(Console.ReadLine());
                groupEnergy -= lostEnergy;
                if (groupEnergy <= 0)
                {
                    haveEnergy = false;
                    break;
                }
                if (i % 2 == 0)
                {
                    totalWather -= totalWather * 0.30;
                    groupEnergy *= 1.05;
                   
                }
                if (i % 3 == 0)
                {
                    //{ currentFood} / { countOfPeople}
                    //and at the same time raises their group’s energy by 10 %.

                    totalFood -= totalFood / numberPlayers;
                   groupEnergy *= 1.10;
                }

            }

            if (haveEnergy)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWather:f2} water.");
            }

        }
    }
}

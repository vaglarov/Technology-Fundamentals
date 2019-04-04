using System;
using System.Collections.Generic;
using System.Linq;

namespace _106._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            //ReadData
            var firstPlayer = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToList();
            var secondPlayer = Console.ReadLine().
                           Split(' ', StringSplitOptions.RemoveEmptyEntries).
                           Select(int.Parse).
                           ToList();
            while (firstPlayer.Count>0&&secondPlayer.Count>0)
            {
                var cardFirst = firstPlayer[0];
                firstPlayer.RemoveAt(0);
                var cardSecond = secondPlayer[0];
                secondPlayer.RemoveAt(0);
                if (cardFirst>cardSecond)
                {
                    firstPlayer.Add(cardFirst);
                    firstPlayer.Add(cardSecond);
                }
                else if (cardFirst<cardSecond)
                {
                    secondPlayer.Add(cardSecond);
                    secondPlayer.Add(cardFirst);

                }
            }
            var winner = string.Empty;
            var pointWinner = default(int);
            if (firstPlayer.Count==0)
            {
                winner = "Second player";
                pointWinner = secondPlayer.Sum();
            }
            else
            {
                winner = "First player";
                pointWinner = firstPlayer.Sum();
            }

            //Print DAta
            PrintResult(winner,pointWinner);
        }

        private static void PrintResult(string nameWinner,int sumWinner)
        {
            Console.WriteLine($"{nameWinner} wins! Sum: {sumWinner}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _3___Tseam_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            var listGames = new List<string>();
            var fistLineGame = Console.ReadLine().Split(' ');
            //Add in List
            foreach (var game in fistLineGame)
            {
                if (!listGames.Contains(game))
                {
                    listGames.Add(game);
                }
            }
            var input = string.Empty;
            while ((input=Console.ReadLine())!= "Play!")
            {
                var commans = input.Split(' ');
                switch (commans[0])
                {
                    case "Install":
                        var game = commans[1];
                        if (!listGames.Contains(game))
                        {
                            listGames.Add(game);
                        }
                        break;
                    case "Uninstall":
                        game = commans[1];
                        if (listGames.Contains(game))
                        {
                            listGames.Remove(game);
                        }
                        break;
                    case "Update":
                        game = commans[1];
                        if (listGames.Contains(game))
                        {
                            listGames.Remove(game);
                            listGames.Add(game);
                        }
                        break;
                    case "Expansion":
                        var gameToExpansion = commans[1].Split('-');
                        game = gameToExpansion[0];
                        var gameWihtExpansion = game + ':' + gameToExpansion[1];
                        if (listGames.Contains(game))
                        {
                            var index=listGames.IndexOf(game);
                            listGames.Insert(index + 1, gameWihtExpansion);
                        }
                        break;
                }
            }

            foreach (var item in listGames)
            {
                Console.Write($"{item} ");
            }
        }
    }
}

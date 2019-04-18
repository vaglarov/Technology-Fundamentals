using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
// Не сортирам по брой членове , а само по име.
class Player
{
    public string NamePlayer { get; set; }
    public string NameTeam { get; set; }
    public bool IsCreator { get; set; }
    public Player(string player, string team, bool isCreator = false)
    {
        this.NamePlayer = player;
        this.NameTeam = team;
        this.IsCreator = isCreator;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        var dictTeam = new SortedDictionary<string, List<Player>>();
        var allplayer = new List<Player>();
        int numberTeam = int.Parse(Console.ReadLine());
        //Creat tema
        for (int i = 0; i < numberTeam; i++)
        {
            
            var lineCreatTeam = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);
            if (dictTeam.ContainsKey(lineCreatTeam[1]))
            {
                Console.WriteLine($"Team {lineCreatTeam[1]} was already created!");
            }
            else
            {

                var player = new Player(lineCreatTeam[0], lineCreatTeam[1], true);
                if (allplayer.Exists(x=>x.NamePlayer== lineCreatTeam[0])&&allplayer.Exists(x=>x.IsCreator==true))
                {
                    Console.WriteLine($"{player.NamePlayer} cannot create another team!");
                }
                else
                {
                    var listPlayer = new List<Player>();
                    listPlayer.Add(player);
                    allplayer.Add(player);
                    dictTeam.Add(lineCreatTeam[1], listPlayer);
                    Console.WriteLine($"Team {lineCreatTeam[1]} has been created by {lineCreatTeam[0]}!");
                }
            }

        }
        //Add team member
        string lineAddMember = Console.ReadLine();
        while (lineAddMember!= "end of assignment")
        {//  0 Petq-> 1 PowerPuffsCoders
            var lineMemeberCommand = lineAddMember.Split("->", StringSplitOptions.RemoveEmptyEntries);
            if (!dictTeam.ContainsKey(lineMemeberCommand[1]))
            {
                Console.WriteLine($"Team {lineMemeberCommand[1]} does not exist!");
            }
            else
            {
                var player = new Player(lineMemeberCommand[0],lineMemeberCommand[1]);
                if (allplayer.Exists(x => x.NamePlayer == lineMemeberCommand[0]))
                {
                Console.WriteLine($"Member {lineMemeberCommand[0]} cannot join team {lineMemeberCommand[1]}!");
                }
                else
                {
                allplayer.Add(player);
                dictTeam[lineMemeberCommand[1]].Add(player);

                }
             }
            lineAddMember = Console.ReadLine();
        }
        //Sort all Team and Print
        SortAllTeamAndPrint(dictTeam);

    }

    private static void SortAllTeamAndPrint(SortedDictionary<string, List<Player>> dictTeam)
    {
        var teamDisband = new List<string>();
        foreach (var kvp in dictTeam)
        {
            if (kvp.Value.Count==1)
            {
                var result = kvp.Value;
                teamDisband.Add(result[0].NameTeam);
            }
            else
            {
                Console.WriteLine($"{kvp.Key}");
            var creator = kvp.Value[0];
                Console.WriteLine($"- {creator.NamePlayer}");
            kvp.Value.RemoveAt(0);
            var listSort = kvp.Value.OrderBy(x => x.NamePlayer).ToList();
                foreach (var item in listSort)
                {
                    Console.WriteLine($"-- {item.NamePlayer}");
                }

            }

        }
        Console.WriteLine("Teams to disband:");
        foreach (var item in teamDisband)
        {
            Console.WriteLine($"{item}");
        }
    }
}


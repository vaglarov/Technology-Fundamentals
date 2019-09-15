using System;
using System.Collections.Generic;

class Room
{
    public string RoomType { get; set; }
    public int PointRoom { get; set; }
    public Room(string room, int point)
    {
        this.RoomType = room;
        this.PointRoom = point;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        int coins = 0;
        int health = 100;
        var commannd = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
        var listRoom = new List<Room>();
        for (int i = 0; i < commannd.Length; i++)
        {
            string[] commandRoom = commannd[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var roomAdd = new Room(commandRoom[0], int.Parse(commandRoom[1]));
            listRoom.Add(roomAdd);
        }
        bool sucsses = true;
        for (int i = 0; i < listRoom.Count; i++)
        {

            var nodeRoom = listRoom[i];
            switch (nodeRoom.RoomType)
            {
                case "potion":
                    var healthToAdd = listRoom[i].PointRoom;
                    var addHealth = 0;
                    if (health + healthToAdd <= 100)
                    {
                        health += healthToAdd;
                        addHealth = healthToAdd;
                    }
                    else
                    {
                        addHealth = 100 - health;
                        health = 100;
                    }

                    Console.WriteLine($"You healed for {addHealth} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                    break;
                case "chest":
                    var coinsAdd = listRoom[i].PointRoom;
                    coins += coinsAdd;
                    Console.WriteLine($"You found {coinsAdd} coins.");
                    break;
                default:
                    var demage = listRoom[i].PointRoom;
                    health -= demage;
                    if (health>0)
                    {
                        Console.WriteLine($"You slayed {listRoom[i].RoomType.ToString()}.");
                    }
                    else
                    {
                        sucsses = false;
                        Console.WriteLine($"You died! Killed by {listRoom[i].RoomType.ToString()}.");
                        Console.WriteLine($"Best room: {i+1}");
                        return;
                    }
                    break;
            }

        }
        if (sucsses)
        {
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}


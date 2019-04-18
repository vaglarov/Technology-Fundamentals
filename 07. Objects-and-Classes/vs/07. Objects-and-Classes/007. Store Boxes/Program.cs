using System;

using System;
using System.Collections.Generic;
using System.Linq;

class Item
{
    public Item(string name,double price)
    {
        this.Name = name;
        this.Price = price;
    }
    public Item() { }

    public string Name { get; set; }
    public double Price { get; set; }
}
//Serial Number, Item, Item Quantity and Price for a Box.
class Box
{
    public Box(int serialNumber,Item item,int itemQuantity,double priceForABox)
    {
        this.SerialNumber = serialNumber;
        this.ItemQuantity = itemQuantity;
        this.PriceForABox = priceForABox;
        this.Item = item;
    }

    public int SerialNumber { get; set; }
    public Item Item { get; set; }
    public int ItemQuantity { get; set; }
    public double PriceForABox { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        var commandLine = Console.ReadLine();
        var listResult = new List<Box>();
        //Add item
        while (commandLine!="end")
        {//          0                 1           2            3
            // {Serial Number} {Item Name} {Item Quantity} {itemPrice}
            var command = commandLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var serialNumber = int.Parse(command[0]);
            var itemName = command[1];
            var itemQuantity = int.Parse(command[2]);
            var itemPrice = double.Parse(command[3]);
            var priceForBox = (double)(itemQuantity*itemPrice);
            var addItem = new Item(itemName, itemPrice);
            var addBox = new Box(serialNumber, addItem, itemQuantity, priceForBox);
            listResult.Add(addBox);
            commandLine = Console.ReadLine();
        }
        PrintResult(listResult);
    }

    private static void PrintResult(List<Box> listResult)
    {
       
        var resultForPrint= listResult.OrderByDescending(x => x.PriceForABox);
        foreach (var item in resultForPrint)
        {
            //{ boxSerialNumber}
            //-- { boxItemName} – ${ boxItemPrice}: { boxItemQuantity}
            //-- ${ boxPrice}
            Console.WriteLine($"{item.SerialNumber}");
            Console.WriteLine($"-- {item.Item.Name} - ${item.Item.Price:f2}: { item.ItemQuantity}");
            Console.WriteLine($"-- ${item.PriceForABox:f2}");


        }
    }
}


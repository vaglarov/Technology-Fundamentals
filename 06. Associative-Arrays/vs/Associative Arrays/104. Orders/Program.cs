using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        var collectionProduct = new Dictionary<string, Produckt>();
        string addProduktLine = Console.ReadLine();
        while (addProduktLine != "buy")
        {
            var addProducktArr = addProduktLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var nameProduct = addProducktArr[0];
            var priceProduct = double.Parse(addProducktArr[1]);
            var quantityProduct = int.Parse(addProducktArr[2]);
            if (!collectionProduct.ContainsKey(nameProduct))
            {
                var newProduct = new Produckt(nameProduct, priceProduct, quantityProduct);
                collectionProduct.Add(nameProduct, newProduct);
            }
            else
            {
                if (collectionProduct[nameProduct].Price != priceProduct)
                {
                    collectionProduct[nameProduct].Price = priceProduct;
                }
                collectionProduct[nameProduct].Quantity += quantityProduct;

            }
            addProduktLine = Console.ReadLine();
        }
            //print 
            foreach (var kvp in collectionProduct)
            {
                //Beer -> 220.00
                var totalSum = kvp.Value.Quantity * kvp.Value.Price;
                Console.WriteLine($"{kvp.Key} -> {totalSum:f2}");
            }
    }
}

class Produckt
{
    public Produckt(string name, double price, int quantity)
    {
        this.Name = name;
        this.Price = price;
        this.Quantity = quantity;
    }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
}

using System;
using System.Collections.Generic;
using System.Linq;

class Car //: Brand, Model and Horse Power.
{
    public Car(string brad, string model, int horsePower)
    {
        this.Brand = brad;
        this.Model = model;
        this.HorsePower = horsePower;
    }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }

}
//: Brand, Model and Weight.
class Truck
{
    public Truck(string brand, string model, int weight)
    {
        this.Brand = brand;
        this.Model = model;
        this.Weight = weight;

    }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }
}

class Catalog
{// { type}/{ brand}/{ model}/{ horse power / weight}
    public List<Car> Cars = new List<Car>();
    public List<Truck> Trucks = new List<Truck>();

    public void AddToCatalog(string type, string brand, string model, int powerWeight)
    {
        if (type == "Car")
        {
            var car = new Car(brand, model, powerWeight);
            this.Cars.Add(car);
        }
        else
        {
            var truck = new Truck(brand, model, powerWeight);
            this.Trucks.Add(truck);
        }
    }
    public void SortCatalog()
    {
       this.Cars= this.Cars.OrderBy(x => x.Brand).ToList();
        
        this.Trucks=this.Trucks.OrderBy(x => x.Brand).ToList();

    }
    public int Count()
    {
        return this.Trucks.Count + this.Cars.Count;
    }

    public void PrintResulet()
    {
        if (Cars.Count > 0)
        {
            Console.WriteLine("Cars:");
            foreach (var item in this.Cars)
            {
                Console.WriteLine($"{item.Brand}: {item.Model} - {item.HorsePower}hp");
            }

        }
        if (Trucks.Count > 0)
        {

            Console.WriteLine("Trucks:");
            foreach (var item in this.Trucks)
            {
                Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
            }
        }
    }

}



class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        //ReadData
        //       0   1             2
        // { type}/{ brand}/{ model}/{ horse power / weight}
        string line = Console.ReadLine();
        var catalog = new Catalog();
        while (line != "end")
        {
            var command = line.Split("/", StringSplitOptions.RemoveEmptyEntries);
            var type = command[0];
            var brand = command[1];
            var model = command[2];
            var hpOrweight = int.Parse(command[3]);
            catalog.AddToCatalog(type, brand, model, hpOrweight);
            line = Console.ReadLine();
        }
        catalog.SortCatalog();
        catalog.PrintResulet();
    }
}


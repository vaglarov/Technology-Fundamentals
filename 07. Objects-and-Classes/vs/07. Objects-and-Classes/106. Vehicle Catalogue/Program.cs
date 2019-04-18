using System;
using System.Collections.Generic;
using System.Linq;

class Vehicle
{
    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int HorsePower { get; set; }
    public Vehicle(string type,
        string model,
        string color,
        int hp)
    {
        this.Type = type;
        this.Model = model;
        this.Color = color;
        this.HorsePower = hp;

    }
}
//{model} {color} {horsepower}
class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        var catalog = new List<Vehicle>();
        string command = Console.ReadLine();
        while (command != "End")
        {
            var sepCommand = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            switch (sepCommand[0].ToLower())
            {                     //0     1   2  3
                case "truck":   //truck Man red 200
                    var newVehicle = new Vehicle("Truck", sepCommand[1], sepCommand[2], int.Parse(sepCommand[3]));
                    catalog.Add(newVehicle);
                    break;
                case "car":
                    newVehicle = new Vehicle("Car", sepCommand[1], sepCommand[2], int.Parse(sepCommand[3]));
                    catalog.Add(newVehicle);
                    break;
            }
            command = Console.ReadLine();
        }
        var printFromCatalog = Console.ReadLine();
        while (printFromCatalog != "Close the Catalogue")
        {
            PrintFromCatalog(printFromCatalog, catalog);
            printFromCatalog = Console.ReadLine();
        }
        double averageCarHP=AverrageHPForCars(catalog);
        Console.WriteLine($"Cars have average horsepower of: {averageCarHP:f2}.");
        double averageTruckHP = AverrageHPForTrucks(catalog);
        Console.WriteLine($"Trucks have average horsepower of: {averageTruckHP:f2}.");
    }

    private static double AverrageHPForTrucks(List<Vehicle> catalog)
    {
        var result = catalog.Where(x => x.Type == "Truck").Select(x => x.HorsePower).ToList();
        int countCar = result.Count;
        int sumHp = result.Sum();
        if (sumHp == 0)
        {
            return 0;
        }
        return (double)sumHp / countCar;
    }

    private static double AverrageHPForCars(List<Vehicle> catalog)
    {
        var result = catalog.Where(x => x.Type == "Car").Select(x => x.HorsePower).ToList();
        int countCar = result.Count;
        int sumHp = result.Sum();
        if (sumHp==0)
        {
            return 0;
        }
        return (double)sumHp / countCar;
    }

    private static void PrintFromCatalog(string printFromCatalog, List<Vehicle> catalog)
    {
        var result = catalog.FirstOrDefault(x => x.Model == printFromCatalog);
        Console.WriteLine($"Type: {result.Type}");
        Console.WriteLine($"Model: {result.Model}");
        Console.WriteLine($"Color: {result.Color}");
        Console.WriteLine($"Horsepower: {result.HorsePower}");
    }
}



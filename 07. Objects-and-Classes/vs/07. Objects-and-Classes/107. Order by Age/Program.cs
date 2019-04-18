using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public string Name { get; set; }
    public int ID { get; set; }
    public int Age { get; set; }

    public Person(string name, int id, int age)
    {
        this.Name = name;
        this.ID = id;
        this.Age = age;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        string lineInput = Console.ReadLine();
        var listPeople = new List<Person>();
        while (lineInput != "End")
        {
            var lineArr = lineInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var newPerson = new Person(lineArr[0], int.Parse(lineArr[1]), int.Parse(lineArr[2]));
            listPeople.Add(newPerson);
            lineInput = Console.ReadLine();
        }
        listPeople = listPeople.OrderBy(x => x.Age).ToList();
        foreach (var item in listPeople)
        {
            Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
        }
    }
}


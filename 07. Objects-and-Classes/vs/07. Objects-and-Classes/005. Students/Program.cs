using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public Student(string firstName, string lastName, int age, string homeTown)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.HomeTown = homeTown;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }


}

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        string commandInput = Console.ReadLine();
        var listStudents = new List<Student>();
        while (commandInput != "end")
        {
            var listInputToAdd = commandInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string firstName = listInputToAdd[0];
            string lastName = listInputToAdd[1];
            int age = int.Parse(listInputToAdd[2]);
            string homeTownToAdd = listInputToAdd[3].ToString();

            var node = new Student(firstName, lastName, age, homeTownToAdd);
            listStudents.Add(node);
            commandInput = Console.ReadLine();
        }
        string searchTown = Console.ReadLine();
        PrintResult(searchTown, listStudents);

    }

    private static void PrintResult(string searchTown, List<Student> listStudents)
    {
        foreach (var item in listStudents)
        {   
            if (searchTown==item.HomeTown)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
            }
        }
    }
}


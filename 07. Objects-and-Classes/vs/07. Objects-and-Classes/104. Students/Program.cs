using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public Student(string firstName, string lastName, double grade)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Grade = grade;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }
    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
    }

}

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        var collectionStudent = new List<Student>();
        int numberStudent = int.Parse(Console.ReadLine());
        //"{first name} {second name} {grade}"
        for (int i = 0; i < numberStudent; i++)
        {
            var lineInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var student = new Student(lineInput[0], lineInput[1],double.Parse(lineInput[2]));
            collectionStudent.Add(student);
        }
        collectionStudent = collectionStudent.OrderByDescending(x => x.Grade).ToList();

        foreach (var item in collectionStudent)
        {
            Console.WriteLine(item.ToString());
        }
    }

}


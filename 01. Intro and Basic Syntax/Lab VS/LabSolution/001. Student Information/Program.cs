using System;

namespace _001._Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameStudent = Console.ReadLine();
            int ageStudent = int.Parse(Console.ReadLine());
            double gradeStudent = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {nameStudent}, Age: {ageStudent}, Grade: {gradeStudent:f2}");
        }
    }
}

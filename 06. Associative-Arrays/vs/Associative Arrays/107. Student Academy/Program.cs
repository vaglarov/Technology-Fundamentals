using System;
using System.Collections.Generic;
using System.Linq;

namespace _107._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int numberLineInput = int.Parse(Console.ReadLine());
            var dictStudentsGrade = new Dictionary<string, List<double>>();
            for (int i = 0; i <numberLineInput; i++)
            {
                var studentsName = Console.ReadLine();
                var mark = double.Parse(Console.ReadLine());
                if (!dictStudentsGrade.ContainsKey(studentsName))
                {
                    dictStudentsGrade.Add(studentsName, new List<double>());
                }
                dictStudentsGrade[studentsName].Add(mark);
            }
            foreach (var kvp in dictStudentsGrade.Where(x=>x.Value.Average()>=4.50).OrderByDescending(x=>x.Value.Average()))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():f2}");
            }        
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _106._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string command = string.Empty;
            var dictCourse = new Dictionary<string, List<string>>();
            while ((command=Console.ReadLine())!="end")
            {//Programming Fundamentals : John Smith
                var commandArr = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                var course = commandArr[0];
                var userName = commandArr[1];
                if (!dictCourse.ContainsKey(course))
                {
                    dictCourse.Add(course, new List<string>());
                }
                dictCourse[course].Add(userName);
            }
            foreach (var kvp in dictCourse.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                foreach (var item in kvp.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _110._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var dictByName = new Dictionary<string, int>();
            var dictByTEhnolagy = new Dictionary<string, int>();
            string comand = string.Empty;
            while ((comand=Console.ReadLine())!= "exam finished")
            {
                //Pesho-Java-91
                var inputArr = comand.Split("-", StringSplitOptions.RemoveEmptyEntries);
                var name = inputArr[0];
                var tehnolagy = inputArr[1];
                if (tehnolagy!= "banned")
                {

                var currentPoinSubmit = int.Parse(inputArr[2]);
                if (!dictByName.ContainsKey(name))
                {
                    dictByName.Add(name, currentPoinSubmit);
                    if (!dictByTEhnolagy.ContainsKey(tehnolagy))
                    {
                        dictByTEhnolagy.Add(tehnolagy, 0);
                    }
                    dictByTEhnolagy[tehnolagy] ++;
                }
                else
                {
                    if (dictByName[name]<=currentPoinSubmit)
                    {
                        dictByName[name] = currentPoinSubmit;
                    }
                    dictByTEhnolagy[tehnolagy]++;
                }
                }
                else
                {
                    dictByName.Remove(name);
                }
            }
            Console.WriteLine("Results:");
            foreach (var kvp in dictByName.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {//Pesho | 91 ordered descending by their max points, then by username, in the following format:
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var kvp in dictByTEhnolagy.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {//C# - 2
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}

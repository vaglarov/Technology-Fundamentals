using System;
using System.Collections.Generic;
using System.Linq;

namespace _108._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var dictCompany = new Dictionary<string, List<string>>();
            string lineInput = string.Empty;
            while ((lineInput=Console.ReadLine())!="End")
            {
                var commandArr = lineInput.Split(" -> ");
                var companyName = commandArr[0];
                var companyUserID = commandArr[1];
                if (!dictCompany.ContainsKey(companyName))
                {
                    dictCompany.Add(companyName, new List<string>());
                }
                if (!dictCompany[companyName].Contains(companyUserID))
                {
                    dictCompany[companyName].Add(companyUserID);
                }
            }
            foreach (var kvp in dictCompany.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}

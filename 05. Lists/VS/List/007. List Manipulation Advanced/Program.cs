using System;
using System.Linq;
using System.Collections.Generic;

namespace _007._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var inputList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var firstList = inputList.ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                var listCommands = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                switch (listCommands[0])
                {
                    case "Add":
                        inputList.Add(int.Parse(listCommands[1]));
                        break;
                    case "Remove":
                        inputList.Remove(int.Parse(listCommands[1]));
                        break;
                    case "RemoveAt":
                        inputList.RemoveAt(int.Parse(listCommands[1]));
                        break;
                    case "Insert":
                        inputList.Insert(int.Parse(listCommands[2]), int.Parse(listCommands[1]));
                        break;
                    case "Contains":
                       IsConteinsNumber(inputList, int.Parse(listCommands[1]));
                         break;
                    case "PrintEven":
                        PrintEvenNumberFormList(inputList);
                        break;
                    case "PrintOdd":
                        PrintOddNumberFormList(inputList);
                        break;
                    case "GetSum":
                        Console.WriteLine(inputList.Sum());
                        break;
                    case "Filter":
                        PrintNumberAfterFilte(inputList, listCommands[1], int.Parse(listCommands[2]));
                        break;
                }
                command = Console.ReadLine();
            }
                if (inputList.Count!=firstList.Count)
                {
                    Console.WriteLine(string.Join(' ',inputList));
                }
                else
                {
                    bool haveDifference = ChechListAreTheSame(firstList, inputList);
                    if (haveDifference)
                    {
                        Console.WriteLine(string.Join(' ', inputList));
                    }
                }
            
        }

        private static bool ChechListAreTheSame(List<int> firstList, List<int> inputList)
        {
            for (int i = 0; i < firstList.Count; i++)
            {
                if (firstList[i]!=inputList[i])
                {
                    return true;
                }
            }
            return false;
        }

        private static void PrintNumberAfterFilte(List<int> inputList, string criteriy, int number)
        {
            var resultList = new List<int>();
            switch (criteriy)
            {
                case "<":
                    foreach (var item in inputList)
                    {
                        if (item<number)
                        {
                            resultList.Add(item);
                        }
                    }
                    break;
                case "<=":
                    foreach (var item in inputList)
                    {
                        if (item <= number)
                        {
                            resultList.Add(item);
                        }
                    }
                    break;
                case ">":
                    foreach (var item in inputList)
                    {
                        if (item > number)
                        {
                            resultList.Add(item);
                        }
                    }
                    break;
                case ">=":
                    foreach (var item in inputList)
                    {
                        if (item >= number)
                        {
                            resultList.Add(item);
                        }
                    }
                    break;
            }
            Console.WriteLine(string.Join(' ',resultList));
        }

        private static void PrintOddNumberFormList(List<int> inputList)
        {
            var resultListEven = new List<int>();
            foreach (var item in inputList)
            {
                if (item % 2 != 0)
                {
                    resultListEven.Add(item);
                }
            }
            Console.WriteLine(string.Join(' ', resultListEven));
        }

        private static void PrintEvenNumberFormList(List<int> inputList)
        {
            var resultListEven = new List<int>();
            foreach (var item in inputList)
            {
                if (item%2==0)
                {
                    resultListEven.Add(item);
                }
            }
            Console.WriteLine(string.Join(' ',resultListEven));
        }

        private static void IsConteinsNumber(List<int> inputList, int checkNumber)
        {
            if (inputList.Contains(checkNumber))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
    }
}

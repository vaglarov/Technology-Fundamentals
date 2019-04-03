using System;
using System.Collections.Generic;
using System.Linq;

namespace _111.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var listNumber = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            while (command!="end")
            {
                var commandArr = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                switch (commandArr[0].ToLower())
                {
                    case "exchange":
                        var newList = new List<int>();
                        var index = int.Parse(commandArr[1].ToString())+1;
                        if (index>=listNumber.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        while (index< listNumber.Count)
                        {
                            var removeNumber = listNumber[index];
                            newList.Add(removeNumber);
                            listNumber.RemoveAt(index);
                        }
                        for (int i = 0; i < listNumber.Count; i++)
                        {
                            newList.Add(listNumber[i]);
                        }
                        RefillList(listNumber, newList);
                        break;
                    case "max":
                        if (commandArr[1]=="even")
                        {
                            var evenNumber = listNumber.Where(x => x % 2 == 0).ToList();
                            if (evenNumber.Count==0)
                            {
                                Console.WriteLine("No even number");
                                break;
                            }
                           var maxEven= evenNumber.Max();
                            var resultIndex = listNumber.IndexOf(maxEven);
                            Console.WriteLine(resultIndex);

                        }
                        else if (commandArr[1] == "odd")
                        {
                            var evenNumber = listNumber.Where(x => x % 2 == 1).ToList();
                            if (evenNumber.Count == 0)
                            {
                                Console.WriteLine("No odd number");
                                break;
                            }
                            var maxEven = evenNumber.Max();
                            var resultIndex = listNumber.IndexOf(maxEven);
                            Console.WriteLine(resultIndex);
                        }
                        break;
                    case "min":
                        if (commandArr[1] == "even")
                        {
                            var evenNumber = listNumber.Where(x => x % 2 == 0).ToList();
                            if (evenNumber.Count == 0)
                            {
                                Console.WriteLine("No even number");
                                break;
                            }
                            var maxEven = evenNumber.Min();
                            var resultIndex = listNumber.IndexOf(maxEven);
                            Console.WriteLine(resultIndex);

                        }
                        else if (commandArr[1] == "odd")
                        {
                            var evenNumber = listNumber.Where(x => x % 2 == 1).ToList();
                            if (evenNumber.Count == 0)
                            {
                                Console.WriteLine("No odd number");
                                break;
                            }
                            var maxEven = evenNumber.Min();
                            var resultIndex = listNumber.IndexOf(maxEven);
                            Console.WriteLine(resultIndex);
                        }
                        break;
                    case "first":
                        if (commandArr[2] == "even")
                        {

                        }
                        else if (commandArr[2] == "odd")
                        {

                        }
                        break;
                    case "last":
                        if (commandArr[2] == "even")
                        {

                        }
                        else if (commandArr[2] == "odd")
                        {

                        }
                        break;

                }
                        command = Console.ReadLine();
            }
                Console.WriteLine(string.Join(' ',listNumber));
        }

        private static void RefillList(List<int> listNumber, List<int> newList)
        {
            listNumber.Clear();
            foreach (var item in newList)
            {
                listNumber.Add(item);
            }
            newList.Clear();
        }
    }
}

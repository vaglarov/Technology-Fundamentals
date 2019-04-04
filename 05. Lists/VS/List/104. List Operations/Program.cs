using System;
using System.Collections.Generic;
using System.Linq;

namespace _104._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var listInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();
            var commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (commands[0] != "End")
            {

                switch (commands[0])
                {
                    case "Add":
                        listInput.Add(int.Parse(commands[1]));
                        break;
                    case "Insert":
                        if (int.Parse(commands[2]) >= listInput.Count || int.Parse(commands[2]) < 0)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        listInput.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                        break;
                    case "Remove":
                        if (int.Parse(commands[1]) >= listInput.Count || int.Parse(commands[1]) < 0)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        listInput.RemoveAt(int.Parse(commands[1]));
                        break;
                    case "Shift":
                        var countRotation = int.Parse(commands[2]);
                        if (commands[1] == "right")
                        {
                           var result= MethodShiftRight(listInput, countRotation);
                            listInput = result;
                            break;
                        }
                      
                       var result2=MethodShiftLeft(listInput, countRotation);
                        listInput = result2;
                        break;
                        //•	Shift left { count} – first number becomes last ‘count’ times.
                        //•	Shift right { count} – last number becomes first ‘count’ times.
                }
                commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(string.Join(' ', listInput));
        }

        static List<int> MethodShiftRight(List<int> numbersList, int numberRotation)
        {
            for (int i = 0; i < numberRotation % numbersList.Count; i++)
            {

                int lastElement = numbersList[numbersList.Count - 1];
                for (int j = numbersList.Count - 1; j > 0; j--)
                {
                    numbersList[j] = numbersList[j - 1];
                }
                numbersList[0] = lastElement;
            }
            return numbersList;
        }

        static List<int> MethodShiftLeft(List<int> numbersList, int numberRotation)
        {
            for (int i = 0; i < numberRotation % numbersList.Count; i++)
            {

                int firstElement = numbersList[0];
                for (int j = 0; j < numbersList.Count - 1; j++)
                {
                    numbersList[j] = numbersList[j + 1];

                }
                numbersList[numbersList.Count - 1] = firstElement;
            }
            return numbersList;
        }
    }
}

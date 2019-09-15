using System;
using System.Collections.Generic;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var inputList = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                ToList();

            string command = Console.ReadLine();
            while (command != "Stop")
            {
                var commandList = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                switch (commandList[0])
                {
                    case "Delete":
                        var index = int.Parse(commandList[1]);
                        if (index >= -1 && index < inputList.Count - 1)
                        {
                            inputList.RemoveAt(index + 1);
                        }
                        break;
                    case "Swap":
                        var firstWord = commandList[1];
                        var secondWord = commandList[2];
                        if (inputList.Contains(firstWord) && inputList.Contains(secondWord))
                        {
                            var indexFirst = inputList.IndexOf(firstWord);
                            inputList.Insert(indexFirst, secondWord);
                            inputList.RemoveAt(indexFirst + 1);
                            var indexSecond = inputList.IndexOf(secondWord);
                            inputList.Insert(indexSecond, firstWord);
                            inputList.RemoveAt(indexSecond + 1);
                        }
                        break;
                    //
                    case "Put":
                        var word = commandList[1];
                        var indexAdd = int.Parse(commandList[2]);
                        if (indexAdd-1>=0&&indexAdd<=inputList.Count)
                        {
                            inputList.Insert(indexAdd - 1, word);
                        }
                        //if (indexAdd >= 1 && indexAdd <= inputList.Count - 1)
                        //{
                        //    if (indexAdd == 0)
                        //    {
                        //        inputList.Insert(indexAdd, word);
                        //    }
                        //    inputList.Insert(indexAdd - 1, word);
                        //}
                        break;
                    //ok
                    case "Replace":
                        var wordReplace = commandList[1];
                        var wordToReplace = commandList[2];
                        if (inputList.Contains(wordToReplace))
                        {
                            var indexWordToReplace = inputList.IndexOf(wordToReplace);
                            inputList.Insert(indexWordToReplace, wordReplace);
                            inputList.RemoveAt(indexWordToReplace + 1);
                        }
                        break;
                    case "Sort":
                        var resultList = new List<string>();
                        resultList = inputList.OrderByDescending(x => x).ToList();
                        RefillList(resultList, inputList);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", inputList));
        }

        private static void RefillList(List<string> resultList, List<string> inputList)
        {
            inputList.Clear();
            foreach (var item in resultList)
            {
                inputList.Add(item);
            }
            resultList.Clear();
        }
    }
}

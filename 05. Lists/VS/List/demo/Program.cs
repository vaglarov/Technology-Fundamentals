using System;
using System.Collections.Generic;
using System.Linq;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandList= new List<string>();
            var listNumber = new List<int>();
            var listResult = new List<char>();
            string command = Console.ReadLine();
            while (command != "Visual Studio crash")
            {
                commandList = command.Split("32656 19759 32763", StringSplitOptions.RemoveEmptyEntries).ToList();
                listNumber = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                listNumber.Remove(32656);
                listNumber.Remove(19759);
                listNumber.Remove(32763);
                var lastIndex = listNumber[1];
                for (int i = 1; i <=lastIndex; i++)
                {
                    var numberFromAsci = listNumber[i+2];
                    var character = (char)numberFromAsci;
                    listResult.Add(character);
                }
                Console.WriteLine(string.Join("",listResult));
                listResult.Clear();
                command = Console.ReadLine();
            }
        }
    }
}

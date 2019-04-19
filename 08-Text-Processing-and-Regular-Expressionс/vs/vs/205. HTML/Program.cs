using System;
using System.Collections.Generic;

namespace _205._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var listCommand = new List<string>();
            listCommand.Add(command);
            command = Console.ReadLine();
            listCommand.Add(command);
            while ((command=Console.ReadLine())!= "end of comments")
            {
                listCommand.Add(command);

            }

            Console.WriteLine($"<h1>{Environment.NewLine}{"\t"}{listCommand[0]}{Environment.NewLine}</h1>");
            Console.WriteLine($"<article>{Environment.NewLine}{"\t"}{listCommand[1]}{Environment.NewLine}</article>");
            for (int i = 2; i < listCommand.Count; i++)
            {
                Console.WriteLine($"<div>{Environment.NewLine}{"\t"}{listCommand[i]}{Environment.NewLine}</div>");

            }
        }
    }
}

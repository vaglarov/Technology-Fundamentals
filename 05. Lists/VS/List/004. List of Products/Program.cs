using System;
using System.Collections.Generic;
using System.Linq;

namespace _004._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int numberProductsInput = int.Parse(Console.ReadLine());
            var listProductInput = new List<string>();
            for (int i = 0; i < numberProductsInput; i++)
            {
                listProductInput.Add(Console.ReadLine());
            }
            listProductInput.Sort();
            for (int i = 0; i <numberProductsInput; i++)
            {
                Console.WriteLine($"{i+1}.{listProductInput[i]}");
            }
        }
    }
}

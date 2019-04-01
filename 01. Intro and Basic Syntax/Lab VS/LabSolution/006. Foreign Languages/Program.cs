using System;

namespace _006._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string countryInput = Console.ReadLine();
            switch (countryInput)
            {
                case "England":
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}

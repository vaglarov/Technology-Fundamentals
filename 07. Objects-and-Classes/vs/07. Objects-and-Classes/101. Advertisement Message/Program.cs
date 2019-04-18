using System;
using System.Collections.Generic;

namespace _101._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Arr AllCombination
            string[] phrases = { "Excellent product.", "Such a great product.",
                "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can’t live without this product." };
            string[] events ={ "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!"};
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            int numberOutputPhrase = int.Parse(Console.ReadLine());
            var randomGenerator = new Random();
            var resultList = new List<string>();
            for (int i = 0; i < numberOutputPhrase; i++)
            {
                resultList.Add(phrases[randomGenerator.Next(0, phrases.Length)]);
                resultList.Add(events[randomGenerator.Next(0, events.Length)]);
                resultList.Add(authors[randomGenerator.Next(0, authors.Length)]);
                resultList.Add(cities[randomGenerator.Next(0, cities.Length)]);
                Console.WriteLine(string.Join(' ',resultList));
                resultList.Clear();
            }

        }
    }
}

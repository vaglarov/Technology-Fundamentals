using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _112._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = string.Empty;
            double totalPrice = default(double);
            while ((inputLine = Console.ReadLine()) != "end of shift")
            {
                string pattern = @"^%(?<name>[A-Z][a-z]+)%[^|,$%.]*<(?<product>([A-z]*))>[^|,$%.]*\|(?<quantity>\d+)[^|,$%.]*\|[^|,$%.\d]*(?<price>\d+[.,]?\d*)\$";
                var regexMatch = Regex.Matches(inputLine, pattern);
                if (regexMatch.Count != 0)
                {
                    string nameCustomar = string.Empty;
                    string product = string.Empty;
                    int quantity = default(int);
                    double price = default(double);
                    //{customerName}: {product} - {totalPrice}"   "
                    foreach (Match item in regexMatch)
                    {
                        nameCustomar = item.Groups["name"].Value;
                        product = item.Groups["product"].Value;
                        quantity = int.Parse(item.Groups["quantity"].Value);
                        price = double.Parse(item.Groups["price"].Value);
                    }
                    totalPrice += price* quantity;
                    Console.WriteLine($"{nameCustomar}: {product} - {quantity* price:f2}");
                }
            }
            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}

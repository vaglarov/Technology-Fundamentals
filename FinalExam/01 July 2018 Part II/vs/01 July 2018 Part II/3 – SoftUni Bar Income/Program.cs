using System;
using System.Text.RegularExpressions;

namespace _3___SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            double totalIncome = 0;
            while ((line = Console.ReadLine()) != "end of shift")
            {
                string patternRegex = @"(^%(?<name>[A-Z][a-z]+)%)([^\|\$\%\.\d]*)(\<(?<product>\w+)\>)([^\|\$\%\.\d]*)(\|(?<count>\d+)\|)([^\|\$\%\.\d]*)((?<price>\d*(\.\d+)?)\$)";
                if (Regex.IsMatch(line, patternRegex))
                {
                    var regex = Regex.Match(line, patternRegex);
                    var name = regex.Groups["name"].Value;
                    var product = regex.Groups["product"].Value;
                    var count = int.Parse(regex.Groups["count"].Value);
                    var price = double.Parse(regex.Groups["price"].Value);
                    var totalProduct = count * price;
                    totalIncome += totalProduct;
                    Console.WriteLine($"{name}: {product} - {totalProduct:f2}");
                }

            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}

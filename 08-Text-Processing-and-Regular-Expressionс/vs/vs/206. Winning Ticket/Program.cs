using System;
using System.Text.RegularExpressions;

namespace _206._Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            var tickets = inputLine.Split(", ");
            for (int i = 0; i < tickets.Length; i++)
            {
                var ticket = tickets[i].Trim();
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    var firstPart = ticket.Substring(0, 10);
                    var secondPart = ticket.Substring(10, 10);
                    var pattern = @"[@]{6,}|[#]{6,}|[$]{6,}|[\^]{6,}";
                    if (Regex.IsMatch(firstPart, pattern) && Regex.IsMatch(secondPart, pattern))
                    {
                        var regexFirstPart = Regex.Match(firstPart, pattern);
                        var regexSecondPart = Regex.Match(secondPart, pattern);

                        var smallLenght = regexFirstPart.Length;
                        if (regexFirstPart.Length > regexSecondPart.Length)
                        {
                            smallLenght = regexSecondPart.Length;
                        }
                        if (regexFirstPart.Length == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {smallLenght}{regexFirstPart.ToString()[0]} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {smallLenght}{regexFirstPart.ToString()[0]}");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }


                }
            }
        }
    }
}

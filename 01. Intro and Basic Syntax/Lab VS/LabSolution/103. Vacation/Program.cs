using System;

namespace _103._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeopleInGrupInput = int.Parse(Console.ReadLine());
            double price = 0;
            double totalPrice = 0;
            string grupeTypeInput = Console.ReadLine();
            string dayOfWeekInput = Console.ReadLine();
            switch (grupeTypeInput)
            {
                case "Students":
                    switch (dayOfWeekInput)
                    {
                        case "Friday":
                            price = 8.45;
                            break;
                        case "Saturday":
                            price = 9.80;
                            break;
                        case "Sunday":
                            price = 10.46;
                            break;
                    }
                    break;
                case "Business":
                    switch (dayOfWeekInput)
                    {
                        case "Friday":
                            price = 10.90;
                            break;
                        case "Saturday":
                            price = 15.60;
                            break;
                        case "Sunday":
                            price = 16.0;
                            break;
                    }
                    break;
                case "Regular":
                    switch (dayOfWeekInput)
                    {
                        case "Friday":
                            price = 15.00;
                            break;
                        case "Saturday":
                            price = 20;
                            break;
                        case "Sunday":
                            price = 22.50;
                            break;
                    }
                    break;
            }
            totalPrice = price * numberPeopleInGrupInput;
            if (grupeTypeInput== "Students"&&numberPeopleInGrupInput>=30)
            {
                totalPrice = totalPrice * 0.85;
            }
            if (grupeTypeInput == "Business" && numberPeopleInGrupInput >= 100)
            {
                totalPrice = totalPrice - 10 * price;
            }
            if (grupeTypeInput == "Regular" && numberPeopleInGrupInput >= 10&&numberPeopleInGrupInput<=20)
            {
                totalPrice = totalPrice *0.95;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}

using System;

namespace _007._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeekInput = Console.ReadLine();
            int ageClientInput = int.Parse(Console.ReadLine());
            int price = 0;
            bool isCorrect = true;
            if (ageClientInput<0||ageClientInput>122)
            {
                isCorrect=false;
            }
            else if (ageClientInput>=0&&ageClientInput<=18)
            {
                switch (dayOfWeekInput)
                {
                    case "Weekday":
                        price = 12;
                        break;
                    case "Weekend":
                        price = 15;
                        break;
                    case "Holiday":
                        price = 5;
                        break;
                }
            }
            else if (ageClientInput >18 && ageClientInput <= 64)
            {
                switch (dayOfWeekInput)
                {
                    case "Weekday":
                        price = 18;
                        break;
                    case "Weekend":
                        price = 20;
                        break;
                    case "Holiday":
                        price = 12;
                        break;
                }

            }
            else 
            {
                switch (dayOfWeekInput)
                {
                    case "Weekday":
                        price = 12;
                        break;
                    case "Weekend":
                        price = 15;
                        break;
                    case "Holiday":
                        price = 10;
                        break;
                }

            }
            if (isCorrect)
            {
                Console.WriteLine($"{price}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}

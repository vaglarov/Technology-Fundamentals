using System;

namespace _001._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            var daiesOfWeek = new string []{ "Monday",
  "Tuesday",
  "Wednesday",
  "Thursday",
  "Friday",
  "Saturday",
  "Sunday"
};
            int numberInput = int.Parse(Console.ReadLine());
            if (numberInput>=1&&numberInput<=7)
            {
                Console.WriteLine($"{daiesOfWeek[numberInput-1]}");
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}

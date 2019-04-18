using System;
using System.Linq;

namespace _001._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandListInpit = Console.ReadLine().
                Split('-', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToList();
            var day = commandListInpit[0];
            var month = commandListInpit[1];
            var year = commandListInpit[2];
            DateTime date = new DateTime (year,month,day);
            var dayOfWeek = date.DayOfWeek.ToString();
            Console.WriteLine(dayOfWeek);
        }
    }
}

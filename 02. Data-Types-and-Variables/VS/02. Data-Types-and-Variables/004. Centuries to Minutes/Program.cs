using System;

namespace _004._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuriesInput = int.Parse(Console.ReadLine());
            var newDate = DateTime.Parse($"{centuriesInput * 100}, 01, 1, 0:00");
            var toDays = (newDate - DateTime.MinValue).TotalDays+365;
            var toHours = (newDate - DateTime.MinValue).TotalHours+365*24;
            var toMinutes = (newDate - DateTime.MinValue).TotalMinutes+365*24*60;

            Console.WriteLine($"{centuriesInput} centuries = " +
                $"{centuriesInput*100} years = " +
                $"{toDays} days = " +
                $"{toHours} hours = " +
                $"{toMinutes} minutes");


            
        }
    }
}

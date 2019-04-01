using System;

namespace _004._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputHours = int.Parse(Console.ReadLine());
            int inputMinutes = int.Parse(Console.ReadLine());
            TimeSpan time = new TimeSpan(inputHours, inputMinutes,0);
            TimeSpan addTime = new TimeSpan(0, 30, 0);
            time += addTime;
            Console.WriteLine($"{ time.Hours}:{time.Minutes:d2}");
        }
    }
}

using System;

namespace _103._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPersonInfrontElevator = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int resultNumberCourse = 0;
            if (numberPersonInfrontElevator%capacity!=0)
            {
                resultNumberCourse += 1;
            }
            resultNumberCourse += (numberPersonInfrontElevator / capacity);
            Console.WriteLine(resultNumberCourse);
        }
    }
}

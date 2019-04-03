using System;

namespace _006._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double widhtInput = double.Parse(Console.ReadLine());
            double heightInput = double.Parse(Console.ReadLine());
            double area = CalclateAreaRegtangle(widhtInput, heightInput);
            Console.WriteLine($"{area:F0}");
        }

        static double CalclateAreaRegtangle(double widhtInput, double heightInput)
        {
            return widhtInput * heightInput;
        }
    }
}

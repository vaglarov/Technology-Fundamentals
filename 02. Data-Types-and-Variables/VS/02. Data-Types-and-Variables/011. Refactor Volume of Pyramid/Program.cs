using System;

namespace _011._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double dul, sh, V = 0;
            Console.Write("Length: ");
            dul = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            sh = double.Parse(Console.ReadLine());
            Console.Write("Heigth: ");
            V = double.Parse(Console.ReadLine());
            double volumeOfPiramid = (dul + sh + V) / 3;
            Console.WriteLine($"Pyramid Volume: {volumeOfPiramid:F2}");

        }
    }
}

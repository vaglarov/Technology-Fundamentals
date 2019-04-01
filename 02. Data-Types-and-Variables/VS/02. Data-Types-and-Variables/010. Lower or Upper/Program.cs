using System;
using System.Text;


namespace _010._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char charInput = char.Parse(Console.ReadLine());
            if (char.IsUpper(charInput))
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}

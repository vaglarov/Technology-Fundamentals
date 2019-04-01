using System;

namespace _108._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStepsPiramidsInput = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberStepsPiramidsInput; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }
    }
}

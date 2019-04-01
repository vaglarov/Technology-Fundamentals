using System;

namespace _109._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            //read data
            int startingYieldInput = int.Parse(Console.ReadLine());
            int resultDayes = 0;
            int resultResors = 0;
            //Logical parts

            while (startingYieldInput>=100)
            {
                resultDayes++;
                int amountForDay = startingYieldInput - 26;
                resultResors += amountForDay;
                startingYieldInput -= 10;
            }
            //print
            Console.WriteLine(resultDayes);
            if (resultDayes>=1)
            {
                resultResors -= 26;
            }
            Console.WriteLine(resultResors);
        }
    }
}

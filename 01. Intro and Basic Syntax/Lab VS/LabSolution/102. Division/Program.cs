using System;

namespace _102._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            bool print=true;
            int numberInput = int.Parse(Console.ReadLine());
            string answear = "The number is divisible by ";
            int result = 0;
            if (numberInput%10==0)
            {
                result = 10;
            }
            else if (numberInput%7==0)
            {
                result = 7;
            }
            else if (numberInput % 6 == 0)
            {
                result = 6;
            }
            else if (numberInput % 3 == 0)
            {
                result = 3;
            }
            else if (numberInput % 2 == 0)
            {
                result = 2;
            }
            else
            {
                answear = "Not divisible";
                print = false;
            }
            if (print)
            {
                Console.WriteLine(answear+result);
            }
            else
            {
                Console.WriteLine(answear);
            }

        }
    }
}

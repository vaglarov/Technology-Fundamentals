using System;

namespace _202._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char starString = char.Parse(Console.ReadLine());
            var start = (int)starString;
            char endString = char.Parse(Console.ReadLine());
            var end = (int)endString;
            string inputLine = Console.ReadLine();
            int totalASCII = default(int);
            if (start>=end)
            {
                var temp = start;
                start = end;
                end = temp;
            }
            for (int i = 0; i < inputLine.Length; i++)
            {
                var number = (int)inputLine[i];
                if (start<number&&end>number)
                {
                    totalASCII += number;
                }
            }
            
            Console.WriteLine(totalASCII);
        }
    }
}

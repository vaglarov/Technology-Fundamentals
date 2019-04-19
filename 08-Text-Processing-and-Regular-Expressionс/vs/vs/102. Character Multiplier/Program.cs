using System;

namespace _102._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var lineInput = Console.ReadLine().Split();
            string firstString = lineInput[0];
            string secondString = lineInput[1];
            int totalSum = 0;
            if (firstString.Length>=secondString.Length)
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    int secondStringChar = 0;
                    int firstStringChar = firstString[i];
                    if (secondString.Length-1<i)
                    {
                        secondStringChar = 1;
                    }
                    else
                    {
                        secondStringChar = secondString[i];
                    }
                    totalSum += (secondStringChar * firstStringChar);
                }
            }
            else
            {
               
                    for (int i = 0; i < secondString.Length; i++)
                    {
                        int firstStringChar = 0;
                        int secondStringChar = secondString[i];
                        if (firstString.Length - 1 < i)
                        {
                            firstStringChar = 1;
                        }
                        else
                        {
                            firstStringChar = firstString[i];
                        }
                        totalSum += (secondStringChar * firstStringChar);
                    }
                
            }
            Console.WriteLine(totalSum);
        }
    }
}

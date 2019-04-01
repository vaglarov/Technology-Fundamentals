using System;

namespace _106._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbelLetterInput = Console.ReadLine();
            int sumFat = 0;
            
            for (int i = 0; i < numbelLetterInput.Length; i++)
            {
                int numberFromLette = int.Parse(numbelLetterInput[i].ToString());
                int FactInCurrentLetter = numberFromLette;
                for (int j = numberFromLette-1; j >= 1; j--)
                {
                    FactInCurrentLetter = FactInCurrentLetter * j;
                }
                sumFat += FactInCurrentLetter;
            }

            if (sumFat==int.Parse(numbelLetterInput))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

using System;

namespace _101._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageInput = int.Parse(Console.ReadLine());
            string resultCW = string.Empty;
            if (ageInput>=0&&ageInput<=2)
            {
                resultCW = "baby";
            }
            else if (ageInput >= 3 && ageInput <= 13)
            {
                resultCW = "child";
            }
            else if (ageInput >= 14 && ageInput <= 19)
            {
                resultCW = "teenager";
            }
            else if (ageInput >= 20 && ageInput <= 65)
            {
                resultCW = "adult";
            }
            else if (ageInput > 65)
            {
                resultCW = "elder";
            }
            Console.WriteLine(resultCW);
        }
    }
}

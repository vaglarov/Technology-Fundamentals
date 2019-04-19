using System;
using System.Text.RegularExpressions;

namespace _111._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string pattern = @"(?<before>[A-z])(?<digits>\d+)(?<after>[A-z])";
            var resultRegex = Regex.Matches(inputLine, pattern);
            double totalSum = 0;
            foreach (Match item in resultRegex)
            {
                bool divideOrMultiply = true;//true is upper upper is divide
                var beforeSing = Convert.ToChar(item.Groups["before"].Value);
                if (!Char.IsUpper(beforeSing))
                {
                    divideOrMultiply = false;
                }
                int numberBeforeAlfabet = (int)Convert.ToChar((beforeSing.ToString().ToUpper())) - 64;
                int number = int.Parse(item.Groups["digits"].Value);
                bool subbstracktOfAdd = true; //true is upper => upper is substract
                var afterSing = Convert.ToChar(item.Groups["after"].Value);
                if (!Char.IsUpper(afterSing))
                {
                    subbstracktOfAdd = false;
                }
                int numberAfterAlfabet = (int)Convert.ToChar((afterSing.ToString().ToUpper())) - 64;
                totalSum=SumThisMach(totalSum, divideOrMultiply, numberBeforeAlfabet, number, subbstracktOfAdd, numberAfterAlfabet);
            }
            Console.WriteLine($"{totalSum:F2}");
        }

        private static double SumThisMach(double totalSum, bool divideOrMultiply, int numberBeforeAlfabet, int number, bool subbstracktOfAdd, int numberAfterAlfabet)
        {
            double tempNumber = default(double);
            if (divideOrMultiply)
            {
                tempNumber = (double)number / numberBeforeAlfabet;
            }
            else
            {
                tempNumber = (number * numberBeforeAlfabet);
            }

            if (subbstracktOfAdd)
            {
                tempNumber -= numberAfterAlfabet;
            }
            else
            {
                tempNumber += numberAfterAlfabet;
            }
            return totalSum += tempNumber;
        }
    }
}

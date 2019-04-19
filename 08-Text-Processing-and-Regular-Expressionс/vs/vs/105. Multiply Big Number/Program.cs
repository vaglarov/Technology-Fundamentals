using System;
using System.Text;

namespace _105._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string realyBigNumber = Console.ReadLine();
            int multipleNumber = int.Parse(Console.ReadLine());
            var resultString = new StringBuilder();
            var resude = 0;
            var sing = string.Empty;
            if (multipleNumber != 0)
            {

                for (int i = realyBigNumber.Length - 1; i >= 0; i--)
                {
                    var numberFromString = (realyBigNumber[i]).ToString();
                    if (numberFromString == "-")
                    {
                        sing = numberFromString;
                        break;
                    }
                    var resultMultiple = int.Parse(numberFromString) * multipleNumber + resude;

                    resude = resultMultiple / 10;

                    var addChar = (resultMultiple % 10).ToString();
                    resultString.Insert(0, addChar);
                }

                if (resude >= 1)
                {
                    var addChar = Convert.ToString(resude);
                    resultString.Insert(0, addChar);
                }
                if (sing == "-")
                {
                    resultString.Insert(0, sing);
                }

                Console.WriteLine(resultString.ToString().TrimStart('0'));
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}

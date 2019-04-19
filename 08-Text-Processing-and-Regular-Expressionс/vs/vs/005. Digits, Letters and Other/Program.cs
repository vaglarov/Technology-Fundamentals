using System;
using System.Collections.Generic;
using System.Text;

namespace _005._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string digitsSing = string.Empty;
            var leterSing = string.Empty;
            var otherSing = string.Empty;
            for (int i = 0; i < inputLine.Length; i++)
            {
                char sing = inputLine[i];
                if (!char.IsLetterOrDigit(sing)) { otherSing += sing; }
                else if (char.IsDigit(sing))
                {
                    digitsSing += sing;
                }
                else
                {
                    leterSing += sing;
                }
            }
            if (digitsSing.Length>0)
            {
                Console.WriteLine(digitsSing);
            }
            if (leterSing.Length>0)
            {
                Console.WriteLine(leterSing);
            }
            if (otherSing.Length>0)
            {
                Console.WriteLine(otherSing);
            }
        }
    }


}

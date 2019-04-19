using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _107._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            List<string> input = inputLine
                .Split(new char[] { '>' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int currentLetght = 0;
            int start = 0;

            if (inputLine[0] == '>')
            {
                start = 0;
            }
            else
            {
                start = 1;
            }

            for (int i = start; i < input.Count; i++)
            {
                char first = input[i].First();
                int strength = int.Parse(first.ToString());

                int length = input[i].Length;

                input[i] = new String(input[i].Skip(strength + currentLetght).ToArray());

                if (strength + currentLetght > length)
                {
                    currentLetght = strength + currentLetght - length;
                }

            }

            if (start == 0)
            {
                Console.WriteLine('>' + String.Join(">", input));
            }
            else
            {
                Console.WriteLine(String.Join(">", input));
            }
        }
    }
}

            //class Program
            //{
            //    static void Main(string[] args)
            //    {
            //        string inputLine = Console.ReadLine();
            //        var inputString = new StringBuilder(inputLine);
            //        for (int i = 0; i < inputString.Length; i++)
            //        {
            //            if (CheckChar(inputString[i])&&i<=inputString.Length-1)
            //            {
            //                var nexSymbol = inputString[i + 1].ToString();
            //                for (int j = i+1; i < int.Parse(nexSymbol)+i+1; i++)
            //                {
            //                    if (CheckChar(inputString[j]))
            //                    {
            //                        break;
            //                    }
            //                    inputString.Remove(j, 1);
            //                }
            //            }
            //        }
            //        Console.WriteLine(inputString);
            //    }

//    private static bool CheckChar(char v)
//    {
//        if (v=='>')
//        {
//            return true;
//        }
//        return false;
//    }
//        }
//}

using System;
using System.Text;

namespace _002._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineInput = Console.ReadLine();
            var lineInputSplit = lineInput.Split();
            var result = new StringBuilder();
            //for (int i = 0; i < lineInputSplit.Length; i++)
            //{
            //    var word = lineInputSplit[i];
            //    for (int j = 0; j < word.Length; j++)
            //    {
            //        result += word;
            //    }
            //}
            foreach (var kvp in lineInputSplit)
            {
                for (int j = 0; j < kvp.Length; j++)
                {
                    result.Append(kvp);
                }
            }
            Console.WriteLine(result);
        }
    }
}

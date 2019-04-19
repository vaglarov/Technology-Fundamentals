using System;
using System.Text;

namespace _106._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();
            var indexBefore =default(char);
            var result = new StringBuilder(inputString);
            for (int i = 1; i < result.Length; i++)
            {
                indexBefore = result[i - 1];
                if (indexBefore==result[i])
                {
                    result.Remove(i, 1);
                i-=1;
                }
            }
            Console.WriteLine(result);
        }
    }
}

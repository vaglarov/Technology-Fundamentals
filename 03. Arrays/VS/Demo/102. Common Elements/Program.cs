using System;
using System.Collections.Generic;
using System.Linq;

namespace _102._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        { 
            var firstStringArr=Console.ReadLine().Split(' ').ToArray();
            var secondStringArr=Console.ReadLine().Split(' ').ToArray();
            List<string> answer = new List<string>();
            for (int i = 0; i < secondStringArr.Length; i++)
            {
                for (int j = 0; j < firstStringArr.Length; j++)
                {
                    if (secondStringArr[i]==firstStringArr[j])
                    {
                        answer.Add(secondStringArr[i]);
                    }
                }
            }
            Console.WriteLine(string.Join(' ',answer));
        }
    }
}

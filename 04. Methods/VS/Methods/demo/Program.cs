using System;
using System.Collections.Generic;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, char> demoTest = new Dictionary<int,char>();
            for (int i = 1; i < 20; i++)
            {
                char a = 'a';
                demoTest.Add(i, a);
                a++;
            }

            foreach (var item in demoTest)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            demoTest.Remove(3);
            demoTest.Add(3, 's');
            foreach (var item in demoTest)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

        }
    }
}

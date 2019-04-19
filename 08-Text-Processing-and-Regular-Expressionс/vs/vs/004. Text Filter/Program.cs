using System;
using System.Linq;
using System.Text;

namespace _004._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordsToCenzors = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            string textToEdit = Console.ReadLine();
            var result = new StringBuilder(textToEdit);
            foreach (var kvp in wordsToCenzors)
            {
                result.Replace(kvp, new string('*', kvp.Length));
            }
            Console.WriteLine(result);
        }
    }
}

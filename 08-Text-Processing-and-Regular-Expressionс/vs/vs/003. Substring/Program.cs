using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _003._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Ice
            //kicegiciceeb
            string stringToRemove = Console.ReadLine().ToLower();
            string removeFrom = Console.ReadLine();
            var result = new StringBuilder();
            result.Append(removeFrom);
            while (removeFrom.IndexOf(stringToRemove)!=-1)
            {
                result.Replace(stringToRemove,string.Empty);
                removeFrom = result.ToString();
            }
            Console.WriteLine(result);
        }
    }
}

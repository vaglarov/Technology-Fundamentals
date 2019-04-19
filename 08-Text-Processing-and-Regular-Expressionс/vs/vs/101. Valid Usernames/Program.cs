using System;

namespace _101._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var inputUsers = inputLine.Split(", ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var userName in inputUsers)
            {
                var lenghtName = false;
                var letterOrDigits = true;
                if (userName.Length >= 3 && userName.Length <= 16)
                {
                    lenghtName = true;

                }
                for (int i = 0; i < userName.Length; i++)
                {
                    var charFromName = userName[i];
                    if (!char.IsLetterOrDigit(charFromName) && charFromName != '-' && charFromName != '_')
                    {
                        letterOrDigits = false;
                    }
                    if (!letterOrDigits)
                    {
                        break;
                    }
                }
                if (lenghtName && letterOrDigits)
                {
                    Console.WriteLine(userName);
                }
            }
        }
    }
}

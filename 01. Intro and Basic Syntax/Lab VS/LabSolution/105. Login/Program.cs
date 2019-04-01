using System;
using System.Linq;

namespace _105._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userNameInput = Console.ReadLine();
            string userPassWord = new string(userNameInput.Reverse().ToArray());
            string commandInput = Console.ReadLine();
            int countToBlock = 1;
            bool isBlock = false;
            while (commandInput!=userPassWord)
            {
                Console.WriteLine("Incorrect password. Try again.");
                countToBlock++;
                if (countToBlock == 4)
                {
                    isBlock = true;
                    break;
                }
                commandInput = Console.ReadLine();
            }
            if (isBlock)
            {
                Console.WriteLine($"User {userNameInput} blocked!");
            }
            else
            {

                Console.WriteLine($"User {userNameInput} logged in.");
            }
           
        }
    }
}

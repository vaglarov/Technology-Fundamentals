using System;
using System.Linq;

namespace _205._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            //readDAta
            int keyFOrDecryptingInput = int.Parse(Console.ReadLine());
            int numberLetterInWordInput = int.Parse(Console.ReadLine());
            //LogigPart
            char[] wordDecrip = new char[numberLetterInWordInput];
            for (int i = 0; i < numberLetterInWordInput; i++)
            {
                wordDecrip[i] = (char)(keyFOrDecryptingInput + char.Parse(Console.ReadLine()));
            }
            //print
            Console.WriteLine(string.Join("",wordDecrip).ToString());
        }
    }
}

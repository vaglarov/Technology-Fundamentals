using System;

namespace _106._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLetter = int.Parse(Console.ReadLine());
            int start = 97;
            for (int i = 0; i < numberLetter; i++)
            {
                for (int j = 0; j  < numberLetter; j ++)
                {
                    for (int k = 0; k < numberLetter; k++)
                    {
                        Console.WriteLine($"{((char)(start+i))}" +
                            $"{((char)(start + j))}" +
                            $"{((char)(start + k))}");
                    }

                }
            }
        }
    }
}

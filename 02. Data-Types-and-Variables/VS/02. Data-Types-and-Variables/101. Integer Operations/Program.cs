using System;

namespace _101._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] inputTable = new Int32[4];
            Int32 result = 0;
            for (int i = 0; i < 4; i++)
            {
                inputTable[i] = Int32.Parse(Console.ReadLine());
            }
            result = ((inputTable[0] + inputTable[1]) / inputTable[2]) * inputTable[3];
            Console.WriteLine(result);
        }
    }
}

using System;

namespace _011._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToMakeTable = int.Parse(Console.ReadLine());
            int startTableForm = int.Parse(Console.ReadLine());
            if (numberToMakeTable>10 ||startTableForm>10)
            {
                int result = numberToMakeTable * startTableForm;
                Console.WriteLine($"{numberToMakeTable} X {startTableForm} = {result}");
            }
            for (int i = startTableForm; i <= 10; i++)
            {
                int result = numberToMakeTable * i;
                Console.WriteLine($"{numberToMakeTable} X {i} = {result}");
            }
        }
    }
}

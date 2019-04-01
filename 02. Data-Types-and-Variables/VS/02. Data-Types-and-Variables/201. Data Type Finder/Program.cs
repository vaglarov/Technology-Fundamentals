using System;

namespace _201._Data_Type_Finder
{
    class Program
    {
        static void Main()
        {
            //readData
            string argInput = Console.ReadLine();
            //Logical part
            string currentType = string.Empty;
            while (argInput != "END")
            {
                int isInteger = 0;
                double isDouble = 0;
                //integer
                if (int.TryParse(argInput, out isInteger))
                {
                    currentType = "integer";
                }
                //double
                else if (double.TryParse(argInput, out isDouble))
                {
                    currentType = "floating point";
                }
                //char
                else if (argInput.Length == 1)
                {
                    currentType = "character";
                }
                //bool
                else if (argInput.ToLower() == "false" || argInput.ToLower() == "true")
                {
                    currentType = "boolean";

                }
                //string
                else if (argInput.Length > 1)
                {
                    currentType = "string";
                }

                //Result and Print
                Console.WriteLine($"{argInput} is {currentType} type");
                argInput = Console.ReadLine();
            }
        }
    }
}

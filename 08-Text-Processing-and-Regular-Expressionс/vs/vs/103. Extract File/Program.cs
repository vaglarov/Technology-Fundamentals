using System;

namespace _103._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            //C:\Internal\training-internal\Template.pptx
            string inputPath = Console.ReadLine();
            var separatInput = inputPath.Split('\\');

            var last = separatInput[separatInput.Length - 1].Split('.');
            var fileName = last[0];
            var extention = last[1];
                Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extention}");
        }
    }
}

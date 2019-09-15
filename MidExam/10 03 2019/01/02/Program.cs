using System;
using System.Collections.Generic;
using System.Linq;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            //High = 89#Meduim = 53#Low = 28#Medium = 77#Low = 23
            var inputLine = Console.ReadLine().Split("#", StringSplitOptions.RemoveEmptyEntries);
            var watherInput = int.Parse(Console.ReadLine());
            var listCell = new List<int>();
            double effort = 0;
            for (int i = 0; i < inputLine.Length; i++)
            {
                var cell = inputLine[i].Split(" = ", StringSplitOptions.RemoveEmptyEntries);
                var volume = int.Parse(cell[1]);
                var reduseWather = volume * 1.25;
                if (watherInput -reduseWather >= 0)
                {
                    switch (cell[0])
                    {
                        case "High":
                            if (volume >= 81 && volume <= 125)
                            {

                                listCell.Add(volume);
                                effort += volume * 0.25;
                                watherInput -= (int)Math.Ceiling((double)reduseWather);
                                if (watherInput==0)
                                {
                                    break;
                                }
                            }
                            break;
                        case "Medium":
                            if (volume >= 51 && volume <= 80)
                            {

                                listCell.Add(volume);
                                effort += volume * 0.25;
                                watherInput -= (int)Math.Ceiling((double)reduseWather);
                                if (watherInput == 0)
                                {
                                    break;
                                }
                            }
                            break;
                        case "Low":
                            if (volume >= 1 && volume <= 50)
                            {

                                listCell.Add(volume);
                                effort += volume * 0.25;
                                watherInput -= (int)Math.Ceiling((double)reduseWather);
                                if (watherInput == 0)
                                {
                                    break;
                                }
                            }
                            break;
                    }
                }
            }
            Console.WriteLine("Cells:");
            for (int i = 0; i < listCell.Count; i++)
            {
                Console.WriteLine($"- {listCell[i]}");
            }

            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: {listCell.Sum()}");
        }
    }
}

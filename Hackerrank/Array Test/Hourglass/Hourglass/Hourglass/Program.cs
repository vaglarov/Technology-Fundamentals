using System;
using System.Linq;

namespace Hourglass
{
    class Program
    {
        static int Row;
        static int Col;
        static int[,] ArrayInput;
        static int MaxSumHourglass = int.MinValue;
        static int[,] MaxSumHourglassArr;
        static void Main(string[] args)
        {
            SetResultArr();
            ReadArrayArguments();
            ReadArray();
            FindMasSum();
            PrintMaxSumHourglassArr();
            
        }

        private static void PrintMaxSumHourglassArr()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"MAX SUM ARR:{MaxSumHourglass}");
            for (int row = 0; row < MaxSumHourglassArr.GetLength(0); row++)
            {
                string line = string.Empty;
                for (int col = 0; col < MaxSumHourglassArr.GetLength(1); col++)
                {
                    line += MaxSumHourglassArr[row, col];
                }
                Console.WriteLine(line);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void SetResultArr()
        {
            MaxSumHourglassArr = new int[3, 3];
            for (int row = 0; row < MaxSumHourglassArr.GetLength(0); row++)
            {
                for (int col = 0; col < MaxSumHourglassArr.GetLength(1); col++)
                {
                    MaxSumHourglassArr[row, col] = 0;
                }
            }
        }

        private static void FindMasSum()
        {
            for (int row = 0; row < ArrayInput.GetLength(0) - 3; row++)
            {
                for (int col = 0; col < ArrayInput.GetLength(1) - 3; col++)
                {
                    int currentSum = 0;
                    for (int currentRow = row; currentRow < row + 3; currentRow++)
                    {
                        for (int currentCol = col; currentCol < col + 3; currentCol++)
                        {
                            if (currentRow + 1 != row && currentCol != col ||
                                currentRow + 1 != row && currentCol + 2 != col)
                            {
                                currentSum += ArrayInput[currentRow, currentCol];

                            }
                        }
                    }

                    if (currentSum > MaxSumHourglass)
                    {
                        MaxSumHourglass = currentSum;
                        for (int currentRow = row; currentRow < row + 3; currentRow++)
                        {
                            for (int currentCol = col; currentCol < col + 3; currentCol++)
                            {
                                if (currentRow + 1 != row && currentCol != col ||
                                    currentRow + 1 != row && currentCol + 2 != col)
                                {
                                    MaxSumHourglassArr[currentRow-row,currentCol-col] = ArrayInput[currentRow, currentCol];

                                }
                            }
                        }
                    }

                }
            }
        }

        private static void ReadArray()
        {
            ArrayInput = new int[Row, Col];
            for (int row = 0; row < Row; row++)
            {
                int[] readLine = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
                for (int col = 0; col < Col; col++)
                {
                    ArrayInput[row, col] = readLine[col];
                }
            }
        }

        private static void ReadArrayArguments()
        {
            Row = int.Parse(Console.ReadLine());
            Col = int.Parse(Console.ReadLine());

        }
    }
}

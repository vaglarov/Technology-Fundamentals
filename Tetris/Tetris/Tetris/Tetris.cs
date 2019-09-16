using System;
using System.Collections.Generic;
using System.Threading;

namespace Tetris
{
    class Tetris
    {
        //Settings Tetris
        static int TetrisRows = 20;
        static int TetrisCols = 10;
        static int InfoCols = 10;
        static int ConsoleRows = 1 + TetrisRows + 1;
        static int ConsoleCols = 1 + TetrisCols + 1 + InfoCols + 1;
        static List<bool[,]> TetrisFigures = CreateTetrisFigutes();
        static int[] ScorePerLines = new int[] { 0, 40, 100, 300, 1200 };


        //State 
        static int Score = 0;
        static int Frame = 0;
        static int FramesToMoveFigure = 15;

        //static int CurrentFigureIndex = 2;
        static bool[,] CurrentFigure = null;

        static int CurrentFigureRow = 0;
        static int CurrentFigureCol = 0;
        static bool[,] TetrisField = new bool[TetrisRows, TetrisCols];
        static Random Random = new Random();

        static void Main(string[] args)
        {
            ConsoleSettings();
            DrawBorder();
            DrawInfo();
            CurrentFigure = TetrisFigures[Random.Next(0, TetrisFigures.Count)];
            while (true)
            {
                Frame++;
                if (Frame % FramesToMoveFigure == 0)
                {
                    CurrentFigureRow++;
                    Frame = 0;
                    //Score++;
                }
                if (Collision())
                {
                    AddCurrentFigureToTetrisField();
                    int lines = CheckForFullLines();
                    Score += ScorePerLines[lines];
                    CurrentFigure = TetrisFigures[Random.Next(0, TetrisFigures.Count)];
                    CurrentFigureRow = 0;
                    CurrentFigureCol = Random.Next(1, TetrisCols - CurrentFigure.GetLength(1));
                    if (Collision())
                    {
                        GameOver();
                        Console.ReadKey();
                    }
                }

                //Push button
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        return;
                    }
                    //Move Left
                    if (key.Key == ConsoleKey.LeftArrow ||
                        key.Key == ConsoleKey.A)
                    {
                        if (CurrentFigureCol > 0)
                        {
                            CurrentFigureCol--;
                        }
                    }
                    //Move Right
                    if (key.Key == ConsoleKey.RightArrow ||
                        key.Key == ConsoleKey.D)
                    {
                        if (CurrentFigureCol < TetrisCols - CurrentFigure.GetLength(1))
                        {
                            CurrentFigureCol++;
                        }
                    }
                    //Fast Down
                    if (key.Key == ConsoleKey.DownArrow ||
                       key.Key == ConsoleKey.S)
                    {
                        Frame = 1;
                        Score++;
                        CurrentFigureRow++;
                    }
                    //Rotate
                    if (key.Key == ConsoleKey.Spacebar ||
                        key.Key == ConsoleKey.UpArrow ||
                        key.Key == ConsoleKey.W)
                    {
                        RotateCurrentfigure();
                    }
                }
                DrawBorder();
                DrawInfo();
                DrawTetrisField();
                DrawCurrentFigure();

                //Suspends the current thread for the specified number of milliseconds.
                Thread.Sleep(40);
            }

        }

        private static void RotateCurrentfigure()
        {
            var newFigure = new bool[CurrentFigure.GetLength(1), CurrentFigure.GetLength(0)];

            for (int row = 0; row < CurrentFigure.GetLength(0); row++)
            {
                for (int col = 0; col < CurrentFigure.GetLength(1); col++)
                {
                    newFigure[col, CurrentFigure.GetLength(0)-row-1] = CurrentFigure[row, col];
                }
            }

            CurrentFigure = newFigure;
        }

        private static int CheckForFullLines()
        {
            int lines = 0;
            for (int row = 0; row < TetrisField.GetLength(0); row++)
            {
                bool rowIsFull = true;
                for (int col = 0; col < TetrisField.GetLength(1); col++)
                {
                    if (!TetrisField[row, col])
                    {
                        rowIsFull = false;
                        break;
                    }
                }
                if (rowIsFull)
                {
                    for (int rowToMove = row; rowToMove >= 1; rowToMove--)
                    {
                        for (int colToMove = 0; colToMove < TetrisField.GetLength(1); colToMove++)
                        {
                            TetrisField[rowToMove, colToMove] = TetrisField[rowToMove - 1, colToMove];
                        }

                    }
                    lines++;
                }
            }

            return lines;
        }

        private static void AddCurrentFigureToTetrisField()
        {
            for (int row = 0; row < CurrentFigure.GetLength(0); row++)
            {
                for (int col = 0; col < CurrentFigure.GetLength(1); col++)
                {
                    if (CurrentFigure[row, col])
                    {
                        TetrisField[CurrentFigureRow + row, CurrentFigureCol + col] = true;
                    }
                }
            }

        }

        private static bool Collision()
        {
            if (CurrentFigureRow + CurrentFigure.GetLength(0) == TetrisRows)
            {
                return true;
            }
            for (int row = 0; row < CurrentFigure.GetLength(0); row++)
            {
                for (int col = 0; col < CurrentFigure.GetLength(1); col++)
                {
                    if (CurrentFigure[row, col]
                        && TetrisField[CurrentFigureRow + 1 + row, CurrentFigureCol + col])
                    {
                        return true;
                    }
                }
            }


            return false;
        }
        private static List<bool[,]> CreateTetrisFigutes()
        {
            var figures = new List<bool[,]>()
            {
                //----
                new bool[,]
                {
                    {true,true,true,true }
                },
                //o
                new bool[,]
                {
                     {true,true},
                     {true,true}
                },
                //T
                new bool[,]
                {
                    {false,true,false},
                    {true,true,true }
                },
                //s
                new bool[,]
                {
                      {false,true,true},
                    {true,true,false}
                },
                //z
                new bool[,]
                {
                    {true,true,false},
                    {false,true,true}
                },
                //L
                new bool[,]
                {
                    {false,false,true},
                    {true,true,true}
                },
                //J
                new bool[,]
                {
                    {true,false,false},
                    {true,true,true}
                },
            };
            return figures;
        }
        private static void DrawCurrentFigure()
        {
            for (int row = 0; row < CurrentFigure.GetLength(0); row++)
            {
                for (int col = 0; col < CurrentFigure.GetLength(1); col++)
                {
                    if (CurrentFigure[row, col])
                    {
                        WriteWhitColor("█", row + 1 + CurrentFigureRow, col + 1 + CurrentFigureCol, ConsoleColor.Yellow);
                    }
                }
            }

        }
        private static void DrawTetrisField()
        {
            for (int row = 0; row < TetrisField.GetLength(0); row++)
            {
                for (int col = 0; col < TetrisField.GetLength(1); col++)
                {
                    if (TetrisField[row, col])
                    {
                        WriteWhitColor("█", row + 1, col + 1);
                    }
                }
            }
        }
        private static void DrawInfo()
        {
            WriteWhitColor("Score:", 1, 3 + TetrisCols);
            string points = Score.ToString();
            WriteWhitColor(points, 2, 3 + TetrisCols);
            WriteWhitColor("Frame:", 4, 3 + TetrisCols);
            WriteWhitColor(Frame.ToString(), 5, 3 + TetrisCols);
            WriteWhitColor("Position:", 7, 3 + TetrisCols);
            WriteWhitColor($"{CurrentFigureRow}. {CurrentFigureCol}", 8, 3 + TetrisCols);
            WriteWhitColor("Keys:", 10, 3 + TetrisCols);
            WriteWhitColor($"     ^", 11, 3 + TetrisCols);
            WriteWhitColor($"   < V >", 12, 3 + TetrisCols);
        }
        private static void DrawBorder()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(0, 0);

            char topLeft = '╔';
            char topRight = '╗';
            char topCenter = '╦';

            char bottomLeft = '╚';
            char bottomRight = '╝';
            char bottomCenter = '╩';

            char horizontal = '═';
            char vertical = '║';

            string topLine = topLeft + new string(horizontal, TetrisCols) + topCenter + new string(horizontal, TetrisCols) + topRight;
            Console.WriteLine(topLine);
            for (int i = 0; i < TetrisRows; i++)
            {
                string middleLine = vertical + new string(' ', TetrisCols) + vertical + new string(' ', TetrisCols) + vertical;
                Console.WriteLine(middleLine);
            }

            string bottomLine = bottomLeft + new string(horizontal, TetrisCols) + bottomCenter + new string(horizontal, TetrisCols) + bottomRight;
            Console.WriteLine(bottomLine);
            Console.ForegroundColor = ConsoleColor.White;

        }
        static void WriteWhitColor(string text, int row, int col, ConsoleColor color = ConsoleColor.Green)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(col, row);
            Console.Write(text);
            Console.ResetColor();
        }
        private static void ConsoleSettings()
        {
            Console.Title = "Tetris v1.0";
            Console.WindowHeight = ConsoleRows + 1;
            Console.WindowWidth = ConsoleCols;
            Console.BufferHeight = ConsoleRows + 1;
            Console.BufferWidth = ConsoleCols;
            Console.CursorVisible = false;
        }
        private static void GameOver()
        {
            var scoreAsString = Score.ToString();
            scoreAsString += new string(' ', 9 - scoreAsString.Length);
            WriteWhitColor("╔═══════════╗", 6, 3, ConsoleColor.Cyan);
            WriteWhitColor("║ GAME OVER ║", 7, 3, ConsoleColor.Cyan);
            WriteWhitColor("║   SCORE   ║", 8, 3, ConsoleColor.Cyan);
            WriteWhitColor($"║  {scoreAsString}║", 9, 3, ConsoleColor.Cyan);
            WriteWhitColor("╚═══════════╝", 10, 3, ConsoleColor.Cyan);
        }
    }
}

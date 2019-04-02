using System;
using System.Collections.Generic;
using System.Linq;

namespace _110._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create field and fill with False
            int filedSize = int.Parse(Console.ReadLine());
            int[] bugFiled = new int[filedSize];
            for (int i = 0; i < bugFiled.Length; i++) { bugFiled[i] = 0; }

            //add bugg
            var addBugWithIndex = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            for (int i = 0; i < addBugWithIndex.Count; i++)
            {
                bugFiled[addBugWithIndex[i]] = 1;
            }
            //command
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandLine = command.Split(' ').ToArray();
                int takeBugFrom = int.Parse(commandLine[0]);
                string directionMove = commandLine[1];
                int moveBugTo = int.Parse(commandLine[2]);
                if (moveBugTo < 0)
                {
                    if (directionMove == "left")
                    {
                        directionMove = "right";
                        moveBugTo = moveBugTo * (-1);
                    }
                    else if (directionMove == "right")
                    {
                        directionMove = "left";
                        moveBugTo = moveBugTo * (-1);
                    }
                }
                if (bugFiled[takeBugFrom] == 1)
                {
                    switch (directionMove)
                    {
                        case "right":
                            int moveNext = moveBugTo;
                            bugFiled[takeBugFrom] = 0;
                            while (true)
                            {
                                int newTry = default(int);
                                if ((takeBugFrom + moveBugTo) <= bugFiled.Length - 1)
                                {
                                    if (bugFiled[takeBugFrom + moveBugTo] == 0)
                                    {
                                        bugFiled[takeBugFrom + moveBugTo] = 1;
                                        break;
                                    }
                                    else
                                    {
                                        newTry = takeBugFrom + moveBugTo;
                                        while ((newTry + moveNext) <= bugFiled.Length - 1)
                                        {
                                            if (bugFiled[newTry + moveNext] != 0)
                                            {

                                                if (bugFiled[newTry + moveNext] == 0)
                                                {
                                                    bugFiled[newTry + moveNext] = 1;
                                                    break;
                                                }
                                            }
                                            moveNext++;
                                        }
                                        break;
                                    }

                                }
                                else
                                {

                                break;
                                }
                            }
                            break;
                        case "left":
                            bugFiled[takeBugFrom] = 0;
                            moveNext = moveBugTo;
                            while (true)
                            {
                                int newTry = default(int);
                                if ((takeBugFrom - moveBugTo) >= 0)
                                {
                                    if (bugFiled[takeBugFrom - moveBugTo] == 0)
                                    {
                                        bugFiled[takeBugFrom- moveBugTo] = 1;
                                        break;
                                    }
                                    else
                                    {
                                        newTry = takeBugFrom - moveBugTo;
                                        while ((newTry- moveNext) >= 0)
                                        {
                                            if (bugFiled[newTry - moveNext] != 0)
                                            {

                                                if (bugFiled[newTry - moveNext] == 0)
                                                {
                                                    bugFiled[newTry - moveNext] = 1;
                                                    break;
                                                }
                                            }
                                            moveNext++;
                                        }
                                        break;
                                    }

                                }
                                else
                                {
                                    break;
                                }
                            }
                            break;
                    }
                }
                command = Console.ReadLine();
            }


            //print fild
            Console.WriteLine(string.Join(' ', bugFiled));
        }
    }
}














//using System;
//using System.Linq;

//namespace P10.LadyBugs
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int fieldSize = int.Parse(Console.ReadLine());

//            int[] lbip = Console.ReadLine()
//                .Split()
//                .Select(int.Parse)
//                .ToArray();

//            int[] result = new int[fieldSize];

//            for (int i = 0; i < lbip.Length; i++)
//            {
//                if (lbip[i] < 0 || lbip[i] > fieldSize - 1)
//                {
//                    continue;
//                }
//                result[lbip[i]] = 1;
//            }

//            string command = Console.ReadLine();

//            while (command != "end")
//            {
//                string[] order = command.Split();

//                int position = int.Parse(order[0]);
//                string direction = order[1];
//                int step = int.Parse(order[2]);

//                if (!(position >= 0 && position <= result.Length - 1 && result[position] == 1))
//                {
//                    command = Console.ReadLine();
//                    continue;
//                }

//                result[position] = 0;
//                int newPosition = position;

//                if (direction == "right")
//                {
//                    newPosition += step;
//                    try
//                    {
//                        while (result[newPosition] == 1)
//                        {
//                            //Мисля че по условие е зададено, че когато на търсения индекс вече има калинка, трябва да продължи
//                            //да лети със същата дължина, т.е. newPosition се увеличава със step, а не с единица
//                            newPosition += step;
//                        }

//                        result[newPosition] = 1;
//                    }
//                    catch (Exception)
//                    {
//                        command = Console.ReadLine();
//                        continue;
//                    }
//                }
//                else if (direction == "left")
//                {
//                    newPosition -= step;
//                    try
//                    {
//                        while (result[newPosition] == 1)
//                        {
//                            newPosition -= step; //същото като при righ, позицията се намаля със step
//                        }

//                        result[newPosition] = 1;
//                    }
//                    catch (Exception)
//                    {
//                        command = Console.ReadLine();
//                        continue;
//                    }
//                }

//                command = Console.ReadLine();
//            }
//            Console.WriteLine(string.Join(" ", result));

//        }
//    }
//}
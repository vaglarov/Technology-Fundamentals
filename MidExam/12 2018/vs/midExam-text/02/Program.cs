using System;
using System.Linq;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            var listBadKids = Console.ReadLine()
                .Split("&", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string command = Console.ReadLine();
            while (command != "Finished!")
            {
                var commmandArr = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                switch (commmandArr[0])
                {
                    case "Bad":
                        if (listBadKids.Contains(commmandArr[1]))
                        {
                            break;
                        }
                        listBadKids.Insert(0, commmandArr[1]);
                        break;
                    case "Good":
                        if (!listBadKids.Contains(commmandArr[1]))
                        {
                            break;
                        }
                        listBadKids.Remove(commmandArr[1]);
                        break;
                    case "Rename":
                        //{oldName 1 } {newName 2} 
                        if (!listBadKids.Contains(commmandArr[1]))
                        {
                            break;
                        }
                        var oldIndex = listBadKids.IndexOf(commmandArr[1]);
                        listBadKids.RemoveAt(oldIndex);
                        listBadKids.Insert(oldIndex, commmandArr[2]);
                        break;
                    case "Rearrange":
                        if (!listBadKids.Contains(commmandArr[1]))
                        {
                            break;
                        }
                        var oldIndex1 = listBadKids.IndexOf(commmandArr[1]);
                        listBadKids.RemoveAt(oldIndex1);
                        listBadKids.Add(commmandArr[1]);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",listBadKids));

        }
    }
}

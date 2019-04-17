using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _109._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var dictForce = new Dictionary<string, List<string>>();

            var inputLine = string.Empty;
            while ((inputLine = Console.ReadLine()) != "Lumpawaroo")
            {
                var errorCounter = Regex.IsMatch(inputLine, "->");
                var commandArr = inputLine.Split(new string[] { "|", "->" }, StringSplitOptions.RemoveEmptyEntries);
                switch (errorCounter)
                {
                    case (false):
                        var forse = commandArr[0].Trim();
                        var usersID = commandArr[1].Trim();
                        bool checkExist = ChekIfExistUser(dictForce, usersID);
                        if (!dictForce.ContainsKey(forse)&&!checkExist)
                        {
                            dictForce.Add(forse, new List<string>());
                        }
                        if (!checkExist)
                        {
                            dictForce[forse].Add(usersID);
                        }
                        break;
                    case (true):
                        forse = commandArr[1].Trim();
                        usersID = commandArr[0].Trim();
                        var keyToDelete = string.Empty;
                        var indexItemToDelete = default(int);
                        bool existInDict = false;
                        foreach (var kvp in dictForce)
                        {
                            if (kvp.Value.Contains(usersID))
                            {
                                keyToDelete = kvp.Key;
                                indexItemToDelete = kvp.Value.IndexOf(usersID);
                                existInDict = true;
                                break;
                            }
                        }
                        if (existInDict)
                        {
                            RemoveFromDict(dictForce, keyToDelete, indexItemToDelete);
                        }
                        checkExist = ChekIfExistUser(dictForce, usersID);
                        if (!dictForce.ContainsKey(forse)&&!checkExist)
                        {
                            dictForce.Add(forse, new List<string>());
                        }
                        if (!checkExist)
                        {
                            dictForce[forse].Add(usersID);
                        Console.WriteLine($"{usersID} joins the {forse} side!");
                        }
                        break;
                }
            }
            if (dictForce.Count > 0)
            {
                foreach (var kvp in dictForce.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {

                    Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");
                    foreach (var item in kvp.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {item}");
                    }
                }
            }
        }

        private static bool ChekIfExistUser(Dictionary<string, List<string>> dictForce, string usersID)
        {
            foreach (var kvp in dictForce)
            {
                if (kvp.Value.Contains(usersID))
                {
                    return true;
                }
            }
            return false;

        }

        private static void RemoveFromDict(Dictionary<string, List<string>> dictForce, string keyToDelete, int indexItemToDelete)
        {
            if (dictForce[keyToDelete].Count == 1)
            {
                dictForce.Remove(keyToDelete);
            }
            else
            {
                dictForce[keyToDelete].RemoveAt(indexItemToDelete);
            }
        }
    }
}

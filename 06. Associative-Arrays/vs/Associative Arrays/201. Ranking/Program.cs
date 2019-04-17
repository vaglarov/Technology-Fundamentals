using System;
using System.Collections.Generic;
using System.Linq;

namespace _201._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            var dictContest = new Dictionary<string, string>();
            var dictSudents = new Dictionary<string, Dictionary<string,int>>();
            while (inputLine!= "end of contests")
            {
                //“{contest}:{password for contest}
                var command = inputLine.Split(":");
                var contestName = command[0];
                var contestPass = command[1];
                if (!dictContest.ContainsKey(contestName))
                {
                    dictContest.Add(contestName, contestPass);
                }
                inputLine = Console.ReadLine();
            }
            inputLine = Console.ReadLine();
            while (inputLine != "end of submissions")
            {//“{ contest}=>{ password}=>{ username}=>{ points}
                var command = inputLine.Split("=>");
                var contesName = command[0];
                var contestPass = command[1];
                var studentName = command[2];
                var studentPoint = int.Parse(command[3]);
                if (dictContest.ContainsKey(contesName)&&dictContest[contesName]==contestPass)
                {
                    if (!dictSudents.ContainsKey(studentName))
                    {
                        dictSudents.Add(studentName, new Dictionary<string, int>());
                        dictSudents[studentName].Add(contesName, studentPoint);
                    }
                    else
                    {
                        if (!dictSudents[studentName].ContainsKey(contesName))
                        {
                            dictSudents[studentName].Add(contesName, studentPoint);
                        }
                        else
                        {
                            if (dictSudents[studentName][contesName]<studentPoint)
                            {
                                dictSudents[studentName].Remove(contesName);
                                dictSudents[studentName].Add(contesName, studentPoint);
                            }
                        }
                    }

                }
                inputLine = Console.ReadLine();
            }
            Dictionary<string, int> usernameTotalPoints = new Dictionary<string, int>();
            foreach (var kvp in dictSudents)
            {
                usernameTotalPoints[kvp.Key] = kvp.Value.Values.Sum();
            }
            string bestCandidate = usernameTotalPoints
                .Keys
                .Max();
            int bestPoints = usernameTotalPoints
                .Values
                .Max();
            foreach (var kvp in usernameTotalPoints)
            {
                if (kvp.Value == bestPoints)
                {
                    Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");

                }
            }
            Console.WriteLine("Ranking:");
            foreach (var kvp in dictSudents.OrderBy(x=>x.Key))
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine(string.Join(Environment.NewLine, kvp.Value
                    .OrderByDescending(x => x.Value)
                    .Select(a => $"#  {a.Key} -> {a.Value}")
                    ));
            }

        }
    }
}

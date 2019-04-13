using System;
using System.Collections.Generic;
using System.Linq;

namespace _4___SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var dictUsers = new Dictionary<string, int>();
            var dictLang = new Dictionary<string, int>();
            while ((input=Console.ReadLine())!= "exam finished")
            {
                var command = input.Split('-');
                if (command.Length==3)
                {
                    //Pesho-Java-91
                    var nameUsers = command[0];
                    var language = command[1];
                    var pointSubmit = int.Parse(command[2]);
                    //add User
                    if (!dictUsers.ContainsKey(nameUsers))
                    {
                        dictUsers.Add(nameUsers, pointSubmit);
                    }
                    else if (dictUsers[nameUsers]<pointSubmit)
                    {
                        dictUsers.Remove(nameUsers);
                        dictUsers.Add(nameUsers, pointSubmit);
                    }
                    //AddLanguage
                    if (!dictLang.ContainsKey(language))
                    {
                        dictLang.Add(language, 0);
                    }
                    dictLang[language] += 1;
                }
                else
                {
                    var nameUsersToBand = command[0];
                    if (dictUsers.ContainsKey(nameUsersToBand))
                    {
                        dictUsers.Remove(nameUsersToBand);
                    }
                }

            }
            //print
            Console.WriteLine("Results:");
            foreach (var kvp in dictUsers.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var kvp in dictLang.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }

        }
    }
}

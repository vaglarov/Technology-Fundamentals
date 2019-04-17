using System;
using System.Collections.Generic;
using System.Linq;

namespace _204._Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictDrawf = new Dictionary<string, Dictionary<string, int>>();
            var lineInput = string.Empty;
            while ((lineInput = Console.ReadLine()) != "Once upon a time")
            {//Pesho <:> Red <:> 2000
                var inputSplit = lineInput.Split(" <:> ");
                var nameDrawf = inputSplit[0];
                var colorHat = inputSplit[1];
                var scoreDrawf = int.Parse(inputSplit[2]);
                //add to Dictionary
                if (!dictDrawf.ContainsKey(colorHat))
                {
                    dictDrawf.Add(colorHat, new Dictionary<string, int>());
                    dictDrawf[colorHat].Add(nameDrawf, scoreDrawf);
                }
                else if (!dictDrawf[colorHat].ContainsKey(nameDrawf))
                {
                    dictDrawf[colorHat].Add(nameDrawf, scoreDrawf);
                }
                else if (dictDrawf[colorHat].ContainsKey(nameDrawf) &&
                    dictDrawf[colorHat][nameDrawf] < scoreDrawf)
                {
                    dictDrawf[colorHat].Remove(nameDrawf);
                    dictDrawf[colorHat].Add(nameDrawf, scoreDrawf);
                }


            }
            //(Red) Pesho <-> 2000

            foreach (var kvp in dictDrawf.OrderByDescending(x => x.Value.Values.Max()).ThenByDescending(x => x.Value.Keys.ToString()))
            {
                foreach (var drawf in kvp.Value)
                {
                    Console.WriteLine($"({kvp.Key}) {drawf.Key} <-> {drawf.Value}");
                }
            }
        }
    }
}


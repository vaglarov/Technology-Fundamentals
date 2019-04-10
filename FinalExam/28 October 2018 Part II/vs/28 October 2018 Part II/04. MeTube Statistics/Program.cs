using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._MeTube_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineInput = string.Empty;
            var dictSongViews = new Dictionary<string, int>();
            var dictSongLikes = new Dictionary<string, int>();
            while ((lineInput = Console.ReadLine()) != "stats time")
            {
                string pattern = @"(like:)|(dislike:)";
                var songName = string.Empty;
                if (Regex.IsMatch(lineInput, pattern))
                {
                    var patterLike = @"dislike:";  
                    if (Regex.IsMatch(lineInput, patterLike))
                    {
                        var splitInput = lineInput.Split(":");
                        songName = splitInput[1];
                        if (dictSongViews.ContainsKey(songName))
                        {
                            dictSongLikes[songName] -= 1;
                        }
                    }
                    else 
                    {
                        var splitInput = lineInput.Split(":");
                        songName = splitInput[1];
                        if (dictSongViews.ContainsKey(songName))
                        {
                            dictSongLikes[songName] += 1;
                        }
                      
                    }
                }
                else
                {
                    var splitInput = lineInput.Split("-");
                    songName = splitInput[0];
                    var veiwNumber = int.Parse(splitInput[1]);
                    if (!dictSongViews.ContainsKey(songName))
                    {
                        dictSongViews.Add(songName, 0);
                        dictSongLikes.Add(songName, 0);
                    }
                    dictSongViews[songName] += veiwNumber;
                }

            }
            lineInput = Console.ReadLine();
            if (lineInput == "by views")
            {
                foreach (var kvp in dictSongViews.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{kvp.Key} - {kvp.Value} views - {dictSongLikes[kvp.Key]} likes");
                }
            }
            else
            {
                foreach (var kvp in dictSongLikes.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{kvp.Key} - {dictSongViews[kvp.Key]} views - {kvp.Value} likes");
                }
            }
        }
    }
}

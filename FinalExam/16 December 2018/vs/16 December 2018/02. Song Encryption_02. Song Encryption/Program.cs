using System;
using System.Text.RegularExpressions;

namespace _02._Song_Encryption_02._Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string result = string.Empty;
                var splitCommand = command.Split(":");
                var artistName = splitCommand[0];
                var songName = splitCommand[1];
                string patternArtist = @"^[A-Z][a-z'\s]+$";
                string patternSong = @"^[A-Z\s]{1,}$";
                if (Regex.IsMatch(artistName, patternArtist) && Regex.IsMatch(songName, patternSong))
                {
                    var artist = Regex.Match(artistName, patternArtist);
                    var song = Regex.Match(songName, patternSong);
                    var results = $"{artist}@{song}";
                    var keyDecript = artist.Length;
                    var prinResult = string.Empty;
                    foreach (char symbol in results)
                    {
                        char newSymbol = (char)(symbol+keyDecript);
                        string spacialSymbol = @"[@ ']";
                        bool isSpacialSymbol = Regex.IsMatch(symbol.ToString(), spacialSymbol);
                        if (isSpacialSymbol)
                        {
                            prinResult += symbol.ToString();
                        }
                        else
                        {
                            if (newSymbol>90&&symbol<=90)
                            {
                                newSymbol -= (char)26;
                            }
                            else if (newSymbol > 122 && symbol <= 122)
                            {
                                newSymbol -= (char)26;
                            }
                            prinResult += newSymbol.ToString();
                        }

                    }
                    Console.WriteLine($"Successful encryption: {prinResult}");

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}

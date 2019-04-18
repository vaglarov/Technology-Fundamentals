using System;
using System.Collections.Generic;


    class Song
    {
        //"{typeList}_{name}_{time}
        public Song(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            var timeTotime = time.Split(':');
            this.Time = new TimeSpan(int.Parse(timeTotime[0]), int.Parse(timeTotime[1]), 0);
            //new TimeSpan(values[0], values[1], 0);
        }
        public Song()
        {

        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public TimeSpan Time { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int numberCommands = int.Parse(Console.ReadLine());
            var songs = new List<Song>();

            for (int i = 0; i < numberCommands; i++)
            {
                string[] addSongArr = Console.ReadLine().Split('_', StringSplitOptions.RemoveEmptyEntries);
                songs.Add(new Song(addSongArr[0], addSongArr[1], addSongArr[2]));
            }

            string commandToPrint = Console.ReadLine();
            // print
            //
            PrintResult(commandToPrint, songs);

        }

        private static void PrintResult(string commandToPrint, List<Song> listSongs)
        {
            var listResult = new List<string>();
            string result = string.Empty;
            if (commandToPrint == "all")
            {
                foreach (var item in listSongs)
                {
                    result = item.Name.ToString();
                    listResult.Add(result);
                }
            }
            else
            {
                foreach (var item in listSongs)
                {
                    if (item.TypeList == commandToPrint)
                    {
                        result = item.Name.ToString();
                        listResult.Add(result);
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, listResult));
        }
    }


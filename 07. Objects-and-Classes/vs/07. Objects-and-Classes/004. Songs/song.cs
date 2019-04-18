using System;
using System.Collections.Generic;
using System.Text;

namespace _004._Songs
{
    class Song
    {
        //"{typeList}_{name}_{time}
        public Song(string typeList,string name,string time)
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
}

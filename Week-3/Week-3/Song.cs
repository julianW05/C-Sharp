using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class Song
    {
        public string Artist { get; }
        public string Title { get; }
        public int Duration { get; }

        public Song(string artist, string title, int duration)
        {
            Artist = artist;
            Title = title;
            Duration = duration;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Song other = (Song)obj;
            return Artist == other.Artist && Title == other.Title && Duration == other.Duration;
        }
    }
}

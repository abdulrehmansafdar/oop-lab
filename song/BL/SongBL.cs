using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


        namespace Song
    {
        internal class SongBL
        {
            private string Name;
            private int Duration;
        List<SongBL> songs = new List<SongBL>();

            public SongBL(string name, int duration)
            {
                Name = name;
                Duration = duration;
            }

            public void SetSongName(string name)
            { Name = name; }
            public void SetSongDuration(int duration)
            { Duration = duration; }

            public string GetSongName()
            { return Name; }
            public int GetSongDuration()
            { return Duration; }




        }
    }


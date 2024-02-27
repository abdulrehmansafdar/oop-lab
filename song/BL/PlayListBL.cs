using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song
{
    internal class PlayListBL
    {
        private string Name;
        private int NumberOfSongs;
       private List<SongBL> SongsList = new List<SongBL>();

        public PlayListBL(string name, int nUmberOfSongs)
        {
            Name = name;
            NumberOfSongs = nUmberOfSongs;
           
        }

        public void SetListName(string name)
        {
            Name=name;

        }
        public void SetSongNumber(int num)
        {
          NumberOfSongs = num;

        }

       

        public string GetListName()
            { return Name; }
        public int GetSongNumber()
        { return NumberOfSongs; }
      


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SongBL s1 = new SongBL("A" ,12);
          

            List<PlayListBL> list = new List<PlayListBL>();
            PlayListBL p1 = new PlayListBL("P1", 1);
            list.Add(p1);
            p1.GetListName();
            p1.SetListName("naat");
            p1.GetListName();
            s1.GetSongName();
            s1.SetSongName("buttu");
            s1.GetSongName();
            Console.ReadLine();

        }
    }
}

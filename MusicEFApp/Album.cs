using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicEFApp
{
   
    public class Album
    {
        public int AlbumId { get; set; }
        public string Name { get; set; }

        public virtual List<Song> Song { get; set; }
    }

}

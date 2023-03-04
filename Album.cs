using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSQLApp
{
    internal class Album
    {
        public int ID { get; set; }
        public string AlbumName { get; set; }
        public string Artist { get; set; }
        public int Year { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }

        // List of type track
        public List<Track> Tracks { get; set; }
    }
}

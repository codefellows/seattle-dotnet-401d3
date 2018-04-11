using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class17Demo.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public string Album { get; set; }
        public Playlist Playlist { get; set; }
    }
}

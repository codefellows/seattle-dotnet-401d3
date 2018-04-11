using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class17Demo.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Song> Songs { get; set; }
    }
}

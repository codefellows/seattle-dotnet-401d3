using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class17Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Class17Demo.Data
{
    public class MusicDbContext : DbContext
    {
        public MusicDbContext(DbContextOptions<MusicDbContext> options) : base(options)
        {
            
        }

        //Database tables

        public DbSet<Song> Songs { get; set; }

        //Database tables

        public DbSet<Class17Demo.Models.Playlist> Playlist { get; set; }
     }
}

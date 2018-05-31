using Sedc.MusicManager.WebApp.Models;
using System.Data.Entity;

namespace Sedc.MusicManager.WebApp.Data
{
    public class MusicDb : DbContext
    {
        public DbSet<Song> Songs { get; set; }

        public System.Data.Entity.DbSet<Sedc.MusicManager.WebApp.Models.Album> Albums { get; set; }

        public System.Data.Entity.DbSet<Sedc.MusicManager.WebApp.Models.Artist> Artists { get; set; }
    }
}
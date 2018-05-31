using Sedc.MusicManager.DomainModels;
using System.Data.Entity;

namespace Sedc.MusicManager.WebApp.Data
{
    public class MusicDb : DbContext
    {
        public DbSet<Song> Songs { get; set; }

        public System.Data.Entity.DbSet<Album> Albums { get; set; }

        public System.Data.Entity.DbSet<Artist> Artists { get; set; }
    }
}
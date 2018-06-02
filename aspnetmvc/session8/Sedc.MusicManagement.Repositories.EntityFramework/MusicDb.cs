using Sedc.MusicManagement.Models;
using System.Configuration;
using System.Data.Entity;

namespace Sedc.MusicManagement.Repositories.EntityFramework
{
    public class MusicDb : DbContext
    {
        public MusicDb()
        {

        }
        public DbSet<Artist> Artists { get; set; }
    }
}

using Sedc.MusicManagement.Models;
using System.Data.Entity;

namespace Sedc.MusicManagement.Repositories.EntityFramework
{
    public class MusicDb : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
    }
}

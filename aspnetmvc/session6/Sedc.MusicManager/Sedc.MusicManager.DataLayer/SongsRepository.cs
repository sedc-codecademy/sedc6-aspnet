using Sedc.MusicManager.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sedc.MusicManager.DataLayer
{
    public class SongsRepository
    {
        private readonly MusicDb _db = new MusicDb();
        public List<Song> GetAll()
        {
            return _db.Songs.ToList();
        }
    }
}

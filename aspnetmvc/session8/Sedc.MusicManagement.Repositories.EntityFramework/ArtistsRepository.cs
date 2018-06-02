﻿using Sedc.MusicManagement.Models;
using Sedc.MusicManagement.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sedc.MusicManagement.Repositories.EntityFramework
{
    public class ArtistsRepository : IArtistRepository
    {
        private readonly MusicDb _db;

        public IEnumerable<Artist> GetAll()
        {
            List<Artist> artists = _db.Artists.ToList();
            return artists;
        }

        public Artist GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Artist Create(Artist artist)
        {
            throw new NotImplementedException();
        }

        public Artist Update(Artist artist)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
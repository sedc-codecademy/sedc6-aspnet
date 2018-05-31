using Sedc.MusicManager.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sedc.MusicManager.WebApp.ViewModels
{
    public class CreateSongViewModel
    {
        public Song Song { get; set; }
        public IEnumerable<Album> Albums { get; set; }
    }
}
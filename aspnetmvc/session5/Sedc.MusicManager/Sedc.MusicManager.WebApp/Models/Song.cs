using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sedc.MusicManager.WebApp.Models
{
    public class Song
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Duration { get; set; }

        [ForeignKey("Album")]
        public int AlbumId { get; set; }

        public virtual Album Album { get; set; }
    }
}
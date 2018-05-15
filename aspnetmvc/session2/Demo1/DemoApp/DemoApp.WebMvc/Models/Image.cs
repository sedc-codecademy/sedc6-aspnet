using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApp.WebMvc.Models
{
    public class Image
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public string ImageUrl { get; set; }

    }
}
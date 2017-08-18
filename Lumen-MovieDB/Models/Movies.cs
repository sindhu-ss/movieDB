using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lumen_MovieDB.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public int ReleaseYear { get; set; }
        public string MovieTitle { get; set; }
        public string Description { get; set; }
        public string MovieGenre { get; set; }
        public string featuredImg { get; set; }
    }
}
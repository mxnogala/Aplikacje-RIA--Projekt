using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend2.Models
{
    public class Album
    {
        public int Id { get; set; }

        public string AlbumName { get; set; }

        public string Band { get; set; }

        public int ReleaseYear { get; set; }
    }
}

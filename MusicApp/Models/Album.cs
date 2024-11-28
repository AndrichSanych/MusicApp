using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Models
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        public int Year { get; set; }

        [MaxLength(100)]
        public string Genre { get; set; } 

        public int ArtistId { get; set; }


        [ForeignKey("ArtistId")]
        public Artist Artist { get; set; }
 
        public ICollection<Track> Tracks { get; set; }
    }
}

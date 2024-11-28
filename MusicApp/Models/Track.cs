using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Models
{
    public class Track
    {
        [Key]
        public int TrackId { get; set; } 

        [Required]
        [MaxLength(200)]
        public string Name { get; set; } 

        [Required]
        public double Duration { get; set; } 

        public int AlbumId { get; set; }

        [ForeignKey("AlbumId")]
        public Album Album { get; set; }
    }
}

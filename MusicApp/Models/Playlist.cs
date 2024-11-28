using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Models
{
    public class Playlist
    {
        [Key]
        public int PlaylistId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; } 

        [MaxLength(100)]
        public string Category { get; set; } 
        public ICollection<Track> Tracks { get; set; }
    }
}

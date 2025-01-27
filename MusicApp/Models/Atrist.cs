﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Models
{
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; } 

        [MaxLength(100)]
        public string Country { get; set; } 
        public ICollection<Album> Album { get; set; }
    }

}

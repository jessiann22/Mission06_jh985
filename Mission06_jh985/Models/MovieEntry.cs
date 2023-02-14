using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission06_jh985.Models
{
    public class MovieEntry
    {
        [Required]
        public string Category { get; set; }

        [Required]
        [Key]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent { get; set; }

        [MaxLength (25)]
        public string Notes { get; set; }

    }
}

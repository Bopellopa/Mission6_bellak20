using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_bellak20.Models
{
    public class MovieResponse
    {
        [Key]
        [Required]
        public int ApplicationId { get; set; }
        
        [Required]
        public string Title { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }

        // Foreign Key Relationship
        
        public int CategoryId { get; set; }
        [Required]
        public Category Category { get; set; }

    }
}

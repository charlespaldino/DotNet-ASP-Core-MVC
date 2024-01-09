using ExploreCalifornia.Code;
using System;
using System.ComponentModel.DataAnnotations;

namespace ExploreCalifornia.Models
{
    public class MonthlySpecial
    {
        public long ID { get; set; }

        public String Tags { get; set; }
        
        [Required]      
        public String Name { get; set; }

        [Required]
        public String Description { get; set; }

        [Required]
        public String ImageURL { get; set; }

        [Required]
        public String URL { get; set; }

        [Required]
        public SpecialType Type { get; set; }
        
        [Required]
        public decimal Price { get; set; }

    }
}

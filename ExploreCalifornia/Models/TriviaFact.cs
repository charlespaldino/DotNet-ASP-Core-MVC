using System;
using System.ComponentModel.DataAnnotations;

namespace ExploreCalifornia.Models
{
    public class TriviaFact
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public String Details { get; set; }
    }
}

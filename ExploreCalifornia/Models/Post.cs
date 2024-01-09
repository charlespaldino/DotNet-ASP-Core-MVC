using System;
using System.ComponentModel.DataAnnotations;

namespace ExploreCalifornia.Models
{
    public class Post
    {
        public long ID { get; set; }

        [Display(Name = "Post Title")]
        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Title must be between 5 and 100 characters.")]
        public String Title { get; set; }
        public String Author { get; set; }
        
        [Required]
        [DataType(DataType.MultilineText)]
        [MinLength(10, ErrorMessage = "Blog posts requires a minimum of 10 characters.")]
        public String Body { get; set; } 
        public DateTime Posted { get; set; }
    }
}

using ExploreCalifornia.Code;
using System;
using System.ComponentModel.DataAnnotations;

namespace ExploreCalifornia.Models.Tours
{
    public class TourDetail
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public int TourID { get; set; }

        public String Name { get; set; }

        [Required]
        public String ImageURL { get; set; }

        [Required]
        public String Description { get; set; }

        [Required]
        public RatingType Rating { get; set; }

        [Required]
        public int DurationDays { get; set; }

        [Required]
        public decimal Price { get; set; }

        public String Options { get; set; }

        public TourInfo TourInfo { get; set; }
    }
}

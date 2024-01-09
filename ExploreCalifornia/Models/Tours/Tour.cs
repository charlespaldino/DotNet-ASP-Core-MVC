using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExploreCalifornia.Models.Tours
{
    public class Tour
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public String ImageURL { get; set; }

        public String SplashHTML { get; set; }

        public String SplashPosterURL { get; set; }

        [Required]
        public String Description { get; set; }

        public LinkedList<TourDetail> TourDetails { get; set; }
    }
}

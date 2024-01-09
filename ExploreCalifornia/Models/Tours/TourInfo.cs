using System;
using System.ComponentModel.DataAnnotations;

namespace ExploreCalifornia.Models.Tours
{
    public class TourInfo
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public int TourDetailID { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public String ParentName { get; set; }

        public String SplashPosterURL { get; set; }

        [Required]
        public String SplashHTML { get; set; }


    }
}

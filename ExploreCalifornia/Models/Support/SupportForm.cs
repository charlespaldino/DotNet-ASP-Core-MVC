using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using ExploreCalifornia.Models.Tours;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ExploreCalifornia.Models.Support
{
    public class SupportForm
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public String EmailAddress { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone")]
        public String Mobile { get; set; }

        public String Address { get; set; }

        public String State { get; set; }

        [Display(Name = "Zip Code")]
        public String ZipCode { get; set; }

        [Display(Name = "Tour Date?")]
        [DataType(DataType.Date)] 
        public DateTime? TripDate { get; set; }

        [Display(Name = "Tour")]
        public Tour SelectedTour { get; set; }

        public String TourStatus { get; set; }

        public List<RequestedTourInfoViewModel> RequestedTourInfo  { get; set; }

        public String NewsLetterStatus { get; set; }

        [Required]
        [MaxLength(5000)]
        public String Comments { get; set; }


    }
}

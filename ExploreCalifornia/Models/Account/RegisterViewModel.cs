using System;
using System.ComponentModel.DataAnnotations;

namespace ExploreCalifornia.Models.Account
{
    public class RegisterViewModel
    {
        [Required]
        [MaxLength(100)]
        public String UserName { get; set; }
        [Required]
        [EmailAddress, MaxLength(255)]
        [Display(Name = "Email Address")]
        public String EmailAddress { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public String Password { get; set; }

        [Compare("Password", ErrorMessage = "Password does not match.")]
        [Display(Name = "Confirm Password")]
        public String ConfirmPassword {  get; set; }



    }
}

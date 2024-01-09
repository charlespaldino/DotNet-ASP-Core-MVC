using System.ComponentModel.DataAnnotations;
using System;

namespace ExploreCalifornia.Models.Account
{
    public class LoginViewModel
    {
        [Required]
        [MaxLength(100)]
        public String UserName { get; set; }
      
        [Required]
        [DataType(DataType.Password)]
        public String Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}

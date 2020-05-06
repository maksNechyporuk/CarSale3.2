﻿using System.ComponentModel.DataAnnotations;
namespace CarSale.ViewModel
{


    public class EditUserViewModel
    {



        [Required]
        public string Name { get; set; }



        [Required]
        public string Surname { get; set; }



        [Required]
        [EmailAddress]
        public string Email { get; set; }



        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }



        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password",
            ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }



        [Required]
        public string Country { get; set; }

        [Required]
        public string City { get; set; }
        public string Img { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerceApp.Models.IdentityModels
{
    public class SignUpUserModelVM
    {
        [Required(ErrorMessage = "Please enter your first name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Please enter your Address")]
        public string Address { get; set; }
       

        [Required(ErrorMessage = "Please enter your email")]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please entera strong password")]
        [Compare("ConfirmPassword", ErrorMessage = "Password doesn't match")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Please confirm your password")]
        [Display(Name = "Confirm password")]
        [DataType(DataType.Password)]

        public string ConfirmPassword { get; set; }


    }
}

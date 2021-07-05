﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RekenTrainer.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [DisplayName("Naam")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DisplayName("Wachtwoord")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Herhaal wachtwoord")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match." )]
        public string ConfirmPassword { get; set; }

        [Required]
        [DisplayName("Rol")]
        public string RoleName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RekenTrainer.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DisplayName("Wachtwoord")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Onthou mij?")]
        public bool RememberMe { get; set; }
    }
}

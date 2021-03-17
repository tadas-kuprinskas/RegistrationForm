using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationFormMVC.Models
{
    public class RegistrationModel
    {
        [Required, MinLength(3)]
        [Display(Name = "First Name")]
        public string Name { get; set; }

        [Required, MinLength(3)]
        [Display(Name = "Last Name")]
        public string Surname { get; set; }

        [Required, Range(18, 125)]
        public int Age { get; set; }

        [Required]
        public string City { get; set; }

        [Required, Phone]
        public string Phone { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }
    }
}

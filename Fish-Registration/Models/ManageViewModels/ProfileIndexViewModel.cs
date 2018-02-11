using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fish_Registration.Models.ManageViewModels
{
    public class ProfileIndexViewModel
    {
        public string FirstName {get; set; }

        public string LastName {get; set;}

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public string Nationality { get;set; }
        public DateTime DOB { get;set; }
        public int Height { get; set; }
        public int Weight { get; set; }
    }
}
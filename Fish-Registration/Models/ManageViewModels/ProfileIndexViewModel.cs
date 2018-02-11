using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fish_Registration.Models.ManageViewModels
{
    public class ProfileIndexViewModel
    {
        [Display(Name = "First Name")]
        public string FirstName {get; set; }

        [Display(Name = "Last Name")]
        public string LastName {get; set;}

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public string Nationality { get;set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get;set; }
        public int Height { get; set; }
        public int Weight { get; set; }
    }
}

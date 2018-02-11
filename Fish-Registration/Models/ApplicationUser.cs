using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Fish_Registration.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string Nationality { get;set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get;set; }
        public int Height { get; set; }
        public int Weight { get; set; }
    }
}

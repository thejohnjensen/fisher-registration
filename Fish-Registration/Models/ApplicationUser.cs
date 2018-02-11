using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Fish_Registration.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string Nationality { get;set; }
        public DateTime DOB { get;set; }
        public int Height { get; set; }
        public int Weight { get; set; }
    }
}

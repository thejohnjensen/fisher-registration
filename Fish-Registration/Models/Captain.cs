using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fish_Registration.Models
{
    public class Captain
    {  [Key]
       public int CaptainId { get; set; }
       public string FirstName { get; set;}
       public string LastName { get; set;}
    }
}

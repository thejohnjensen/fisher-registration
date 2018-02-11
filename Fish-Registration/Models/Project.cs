using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Fish_Registration.Models
{
    public class Project
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public CaptainVessel CaptainVesselID { get; set; }
        
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fish_Registration.Models
{
    public class CaptainVessel
    {   [Key]
        public int CaptainVesselId { get; set; }

        public int CaptainID { get; set; }
        public virtual Captain Captain { get; set; }

        public int VesselID { get; set; }
        public virtual Vessel Vessel { get; set; }
    }
}

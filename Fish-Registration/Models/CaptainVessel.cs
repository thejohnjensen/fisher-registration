using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fish_Registration.Models
{
    public class CaptainVessel
    {
        public int ID { get; set; }

        public Captain CaptainID { get; set; }
        public Vessel VesselID { get; set; }
    }
}

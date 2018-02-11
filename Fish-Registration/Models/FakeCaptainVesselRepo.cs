using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fish_Registration.Models
{
    public class FakeCaptainVesselRepo : ICaptainVesselRepo
    {
        public IEnumerable<CaptainVessel> CaptainVessel => new List<CaptainVessel>
        {
            new CaptainVessel {CaptainVesselId = 1, CaptainID = 1},
            new CaptainVessel {CaptainVesselId = 2, CaptainID = 2}
        };
    }
}

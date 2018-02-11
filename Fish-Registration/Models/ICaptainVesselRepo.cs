using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fish_Registration.Models
{
    interface ICaptainVesselRepo
    {
        IEnumerable<CaptainVessel> CaptainVessel { get; }
    }
}

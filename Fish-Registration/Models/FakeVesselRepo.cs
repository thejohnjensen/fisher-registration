using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fish_Registration.Models
{
    public class FakeVesselRepo : IVesselRepo
    {
        public IEnumerable<Vessel> Vessel => new List<Vessel>
        {
            new Vessel {Name = "The Dream", CompanyOwner = "Natgeo", GrossWeight = 100f, VesselId = 1},
            new Vessel {Name = "The Dream", CompanyOwner = "Natgeo", GrossWeight = 200f, VesselId = 2},
            new Vessel {Name = "The Dream", CompanyOwner = "Natgeo", GrossWeight = 300f, VesselId = 3},
            new Vessel {Name = "The Dream", CompanyOwner = "Natgeo", GrossWeight = 400f, VesselId = 4}
        };
        
    }
}

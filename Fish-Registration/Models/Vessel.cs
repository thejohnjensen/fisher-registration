using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fish_Registration.Models
{
	public class Vessel
	{   [Key]
        public int VesselId { get; set; }

        public string Name { get; set; }
        public string CompanyOwner { get; set; }
        public float GrossWeight { get; set; }

        private enum ShipType
        {
            Tanker, Cargo, Fishing, Coaster, Passenger
        }

    }
}

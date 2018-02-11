﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fish_Registration.Models
{
	public class Vessel
	{
        public int VesselID { get; set; }

        public string Name { get; set; }
        public string CompanyOwner { get; set; }
        public float GrossWeight { get; set; }

        private enum ShipType
        {
            Tanker, Cargo, Fishing, Coaster, Passenger
        }

    }
}

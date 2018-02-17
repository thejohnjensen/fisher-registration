using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Fish_Registration.Models
{
    public class Project
    {   
        [Key]
        public int ProjectId { get; set; }

        public string Name { get; set; }
        public int CaptainVesselId { get; set; }
        [Display(Name="Vessel")]
        public virtual CaptainVessel GetCaptainVessel { get; set; }

        public string UserId { get; set; }
        [DataType(DataType.Date)]
        public DateTime Start { get; set; }
        [DataType(DataType.Date)]
        public DateTime End { get; set; }

    }
}

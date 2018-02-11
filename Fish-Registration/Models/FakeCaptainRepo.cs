using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fish_Registration.Models
{
    public class FakeCaptainRepo : ICaptainRepo
    {
        public IEnumerable<Captain> Captain => new List<Captain>
        {
            new Captain {FirstName = "Bill", LastName = "Johnes", CaptainId = 1},
            new Captain {FirstName = "Fill", LastName = "Balanced", CaptainId = 2}
        };
    }
}

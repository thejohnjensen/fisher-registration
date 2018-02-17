using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fish_Registration.Controllers
{
    public class VesselsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}

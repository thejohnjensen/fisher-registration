using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fish_Registration.Controllers
{
    public class IdCardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
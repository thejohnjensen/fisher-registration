using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Fish_Registration.Models;

namespace Fish_Registration.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (User.Claims.Count() == 0) 
            {
                return RedirectToAction(nameof(AccountController.Login), "Account");
            }
            else 
            {
                return View();
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

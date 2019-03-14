using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using formSubmit.Models;

namespace formSubmit
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("result")]
        public IActionResult Result(User answers)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success", answers);
            }
            else
            {
                return View("Index");
            }
        }
        [Route("success")]
        public IActionResult Success()
        {
            return View("Success");
        }
    }
}

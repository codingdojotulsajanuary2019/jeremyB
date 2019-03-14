using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using randPass.Models;


namespace randPass.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            int? num = HttpContext.Session.GetInt32("count");
            if(num == null)
            {
                HttpContext.Session.SetInt32("count", 0);
            }
            else
            {
                int? numz = HttpContext.Session.GetInt32("count");
                HttpContext.Session.SetInt32("count", (int)++numz);
            }
            Password password = new Password();
            string Stuff = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            Random rand = new Random();
            for(int i = 0; i < 14; i++)
            {
                var pword = Stuff[rand.Next(Stuff.Length)];
                password.pwordArr[i] = pword.ToString();
            }
            ViewBag.count = HttpContext.Session.GetInt32("count");

            return View("Index", password);
        }
        [Route("reset")]
        [HttpGet]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

    }
}

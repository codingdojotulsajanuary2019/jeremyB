using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vmFun.Models;

namespace vmFun.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            string message = "lorem ipsum yadda yaddah";
            return View("Index", message);
        }

        [Route("numbers")]
        public IActionResult Numbers()
        {
            int[] numz = new int[]
            {
                1,3,10,7,9,45,90
            };
            return View("Numbers", numz);
        }

        [Route("users")]
        public IActionResult Users()
        {
            User peep1 = new User()
            {
                FirstName = "Potato",
                LastName = "Salad"
            };
            User peep3 = new User()
            {
                FirstName = "Otis",
                LastName = "Dog"
            };
            User peep2 = new User()
            {
                FirstName = "Jeremy",
                LastName = "Bendy"
            };
            List<User> listUser = new List<User>()
            {
                peep1, peep2, peep3
            };
            return View(listUser);
        }
        
        [Route("user")]
        public IActionResult SingleUser()
        {
            User peep1 = new User()
            {
                FirstName = "Potato",
                LastName = "Salad"
            };
            return View(peep1);
        }
    }
}

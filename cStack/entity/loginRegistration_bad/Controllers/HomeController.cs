using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using loginRegistration.Models;
using Microsoft.AspNetCore.Identity;

namespace loginRegistration.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Register")]
        [HttpPost]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                newUser.Password = hasher.HashPassword(newUser, newUser.Password);
                dbContext.Add(newUser);
                dbContext.SaveChanges();
                return RedirectToAction("Login");
            }
            else
            {
                return View("Index");
            }
        }
        [Route("Login")]
        [HttpGet]
        public IActionResult Login()
        {
            return View("Login");
        }
        [Route("Login")]
        [HttpPost]
        public IActionResult Attempt(LoginUser userInfo)
        {
            if(ModelState.IsValid)
            {
                var userDb = dbContext.Users.FirstOrDefault(u => u.Email == userInfo.Email);
                if(userDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(userInfo, userDb.Password, userInfo.Password);
                if (result == 0)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }
                // PUT IN CODE HERE FOR SESSION BULLSHIT
                return RedirectToAction("Success");
            }
            else
            {
                return View("Login");
            }
        }
        [Route("success")]
        [HttpGet]
        public IActionResult Success()
        {
            return View();
        }
        [Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}

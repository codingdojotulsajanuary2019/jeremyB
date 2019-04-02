using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using brightIdeas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace brightIdeas.Controllers
{
    public class UserController : Controller
    {
        private Context dbContext;
        public UserController(Context context)
        {
            dbContext = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            HttpContext.Session.Clear();
            return View();
        }

        [Route("register")]
        [HttpPost]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == newUser.Email))
                {
                    System.Console.WriteLine("Email already exists, redirect");
                    ModelState.AddModelError("newUser.email", "Email already in use!");
                    return View("Index");
                }
                else
                {
                    System.Console.WriteLine("Valid entry, making user");
                    PasswordHasher<User> hasher = new PasswordHasher<User>();
                    newUser.Password = hasher.HashPassword(newUser, newUser.Password);
                    dbContext.Add(newUser);
                    dbContext.SaveChanges();
                    HttpContext.Session.SetString("email", newUser.Email);
                    string checker = HttpContext.Session.GetString("email");
                    System.Console.WriteLine(checker);
                    return RedirectToAction("Ideas", "Idea");
                }
            }
            else
            {
                System.Console.WriteLine("Invalid entry, redirect");
                return View("Index");
            }
        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login(LoginUser logUser)
        {
            if(ModelState.IsValid)
            {
                var userDb = dbContext.Users.FirstOrDefault(u => u.Email == logUser.Email);
                if(userDb == null)
                {
                    ModelState.AddModelError("logUser.Email", "Invalid Email/Password");
                    System.Console.WriteLine("Invalid entry, redirect");
                    return View("Index");
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(logUser, userDb.Password, logUser.Password);
                if (result == 0)
                {
                    ModelState.AddModelError("logUser.Email", "Invalid Email/Password");
                    System.Console.WriteLine("Invalid entry, redirect");
                    return View("Index");
                }
                // PUT IN CODE HERE FOR SESSION BULLSHIT
                HttpContext.Session.SetString("email", logUser.Email);
                System.Console.WriteLine("Valid entry, logged in");
                return RedirectToAction("Ideas", "Idea");
            }
            else
            {
                System.Console.WriteLine("Invalid entry, redirect");
                return View("Index");
            }
        }

        [Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}

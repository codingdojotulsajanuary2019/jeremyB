using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using bankAccounts.Models;
using Microsoft.AspNetCore.Identity;

namespace bankAccounts.Controllers
{
    public class HomeController : Controller
    {
        private Context dbContext;
        public HomeController(Context context)
        {
            dbContext = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [Route("")]
        [HttpPost]
        public IActionResult Register(User newUser)
        {
            System.Console.WriteLine("Register");
            if(ModelState.IsValid)
            {
                System.Console.WriteLine("Valid");
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                newUser.Password = hasher.HashPassword(newUser, newUser.Password);
                dbContext.Add(newUser);
                dbContext.SaveChanges();
                HttpContext.Session.SetString("email", newUser.Email);
                string checker = HttpContext.Session.GetString("email");
                System.Console.WriteLine(checker);
                string userEmail = HttpContext.Session.GetString("email");
                User userFromEmail = dbContext.Users.SingleOrDefault(dude => dude.Email == userEmail);
                int userId = userFromEmail.UserId;
                return RedirectToAction("Account", new {userid = userId});
            }
            else
            {
                System.Console.WriteLine("Invalid");
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
            System.Console.WriteLine("Login");
            if(ModelState.IsValid)
            {
                System.Console.WriteLine("Valid");
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
                HttpContext.Session.SetString("email", userInfo.Email);
                string userEmail = HttpContext.Session.GetString("email");
                User userFromEmail = dbContext.Users.SingleOrDefault(dude => dude.Email == userEmail);
                int userId = userFromEmail.UserId;
                return RedirectToAction("Account", new {userid = userId});
            }
            else
            {
                System.Console.WriteLine("Invalid");
                return View("Login");
            }
        }

        [Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        [Route("account/{userid}")]
        [HttpGet]
        public IActionResult Account(int userid)
        {
            System.Console.WriteLine("Got to show account");
            string userEmail = HttpContext.Session.GetString("email");
            User userFromEmail = dbContext.Users
                .Include(trans => trans.Transactions)
                .SingleOrDefault(dude => dude.Email == userEmail);
            System.Console.WriteLine(userFromEmail);
            if(userFromEmail.UserId != userid)
            {
                System.Console.WriteLine("Users don't match");
                return RedirectToAction("Login");
            }
            else
            {
                System.Console.WriteLine("Users match");
                UserTransaction all = new UserTransaction()
                {
                    loggedUser = userFromEmail
                };
                return View(all);
            }
        }

        [Route("account/{userid}")]
        [HttpPost]
        public IActionResult NewTransaction(Transaction newTrans, int userid)
        {
            if(ModelState.IsValid)
            {
                User user = dbContext.Users.SingleOrDefault(dude => dude.UserId == userid);
                System.Console.WriteLine(newTrans);
                if(newTrans.Amount < 0 && (user.Balance + newTrans.Amount) < 0)
                {
                    return RedirectToAction("Account");
                }
                    user.Balance += newTrans.Amount;
                    dbContext.Add(newTrans);
                    dbContext.SaveChanges();
            }
            return RedirectToAction("Account");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using weddingPlanner.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace weddingPlanner.Controllers
{
    public class WedController : Controller
    {
        private Context dbContext;
        public WedController(Context context)
        {
            dbContext = context;
        }

        [Route("dashboard")]
        [HttpGet]
        public IActionResult Dashboard()
        {
            string user_em = HttpContext.Session.GetString("email");
            User maker = dbContext.Users.SingleOrDefault(u => u.Email == user_em);
            DashVM info = new DashVM()
            {
                creator = maker,
                weddingList = dbContext.Weddings
                    .Include(w => w.creator)
                    .Include(wed => wed.guests)
                    .ThenInclude(guest => guest.user)
                    .ToList()
            };
            return View(info);
        }

        [Route("new")]
        [HttpGet]
        public IActionResult New()
        {
            return View();
        }

        [Route("new")]
        [HttpPost]
        public IActionResult Add(Wedding newWed)
        {
            if(ModelState.IsValid)
            {
                string user_em = HttpContext.Session.GetString("email");
                User maker = dbContext.Users.SingleOrDefault(u => u.Email == user_em);
                newWed.creator = maker;
                dbContext.Add(newWed);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View("New");
            }
        }

        [Route("wedding/{wedId}")]
        [HttpGet]
        public IActionResult Info(int wedId)
        {
            Wedding info = dbContext.Weddings.Include(wed => wed.guests)
            .ThenInclude(g => g.user)
            .SingleOrDefault(wed => wed.weddingId == wedId);
            return View("Wedding", info);
        }

        [Route("attend/{wedId}")]
        [HttpGet]
        public IActionResult Rsvp(int wedId)
        {
            string user_em = HttpContext.Session.GetString("email");
            User freeloader = dbContext.Users.SingleOrDefault(u => u.Email == user_em);
            Wedding wed = dbContext.Weddings.SingleOrDefault(w => w.weddingId == wedId);
            Guest rsvp = new Guest()
            {
                userId = freeloader.UserId,
                weddingId = wed.weddingId
            };
            dbContext.Add(rsvp);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [Route("unattend/{wedId}")]
        [HttpGet]
        public IActionResult un_rsvp(int wedId)
        {
            string user_em = HttpContext.Session.GetString("email");
            User freeloader = dbContext.Users.SingleOrDefault(u => u.Email == user_em);
            Wedding wed = dbContext.Weddings.SingleOrDefault(w => w.weddingId == wedId);
            Guest rsvp = dbContext.Guests.SingleOrDefault(r => r.weddingId == wed.weddingId && r.userId == freeloader.UserId);
            dbContext.Guests.Remove(rsvp);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [Route("delete/{wedId}")]
        [HttpGet]
        public IActionResult delete(int wedId)
        {
            Wedding wed = dbContext.Weddings.SingleOrDefault(w => w.weddingId == wedId);
            dbContext.Weddings.Remove(wed);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using secrets.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace secrets.Controllers
{
    public class SecController : Controller
    {
        private Context dbContext;
        public SecController(Context context)
        {
            dbContext = context;
        }

        [Route("secrets")]
        [HttpGet]
        public IActionResult Secrets()
        {
            string user_em = HttpContext.Session.GetString("email");
            User maker = dbContext.Users.SingleOrDefault(u => u.Email == user_em);
            SecVM info = new SecVM()
            {   
                thisUser = maker,
                allSec = dbContext.Secrets.Include(s => s.creator).Include(s => s.likes).ThenInclude(l => l.user).OrderByDescending(s => s.created_at).Take(5).ToList()
            };
            return View(info);
        }
        [Route("secrets")]
        [HttpPost]
        public IActionResult newSec(Secret newSec)
        {   
            string user_em = HttpContext.Session.GetString("email");
            User maker = dbContext.Users.SingleOrDefault(u => u.Email == user_em);
            newSec.creator = maker;
            dbContext.Add(newSec);
            dbContext.SaveChanges();
            return RedirectToAction("Secrets");
        }
        [Route("delete/{secId}")]
        [HttpGet]
        public IActionResult delSec(int secId)
        {
            Secret thisSec = dbContext.Secrets.SingleOrDefault(s => s.secretId == secId);
            dbContext.Remove(thisSec);
            dbContext.SaveChanges();
            return RedirectToAction("Secrets");
        }

        [Route("like/{secId}")]
        [HttpGet]
        public IActionResult likeSec(int secId)
        {
            Secret thisSec = dbContext.Secrets.SingleOrDefault(s => s.secretId == secId);
            string user_em = HttpContext.Session.GetString("email");
            User maker = dbContext.Users.SingleOrDefault(u => u.Email == user_em);
            Like thisLike = new Like()
            {
                userId = maker.UserId,
                secretId = thisSec.secretId
            };
            dbContext.Add(thisLike);
            dbContext.SaveChanges();
            return RedirectToAction("Secrets");
        }

        [Route("popular")]
        [HttpGet]
        public IActionResult Popular()
        {
            string user_em = HttpContext.Session.GetString("email");
            User maker = dbContext.Users.SingleOrDefault(u => u.Email == user_em);

            SecVM list = new SecVM()
            {
                thisUser = maker,
                allSec = dbContext.Secrets.Include(s => s.likes).ThenInclude(l => l.user).OrderByDescending(s => s.likes.Count()).ToList()
            };
            return View(list);
        }
    }
}
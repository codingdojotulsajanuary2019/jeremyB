using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using activityPlanner.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace activityPlanner.Controllers
{
    public class ActivityController : Controller
    {
        private Context dbContext;
        public ActivityController(Context context)
        {
            dbContext = context;
        }

        [Route("home")]
        [HttpGet]
        public IActionResult Home()
        {
            //Validation for login
            string user_em = HttpContext.Session.GetString("email");
            if(user_em == null)
            {
                return RedirectToAction("Index","User");
            }
            DateTime now = DateTime.Now;
            User logUser = dbContext.Users.SingleOrDefault(u => u.Email == user_em);
            List<Event> activityList = dbContext.Events.Include(e => e.creator).Include(e => e.participants).ThenInclude(p => p.theUser).Where(e => e.fullDT > now).OrderBy(e => e.fullDT).ToList();
            HomeVM info = new HomeVM()
            {
                thisUser = logUser,
                allEvent = activityList
            };
            return View(info);
        }
        
        [Route("new")]
        [HttpGet]
        public IActionResult New()
        {
            string user_em = HttpContext.Session.GetString("email");
            if(user_em == null)
            {
                return RedirectToAction("Index","User");
            }
            return View();
        }

        [Route("new")]
        [HttpPost]
        public IActionResult Add(Event newEvent)
        {
            if(ModelState.IsValid)
            {   
                string user_em = HttpContext.Session.GetString("email");
                User logUser = dbContext.Users.SingleOrDefault(u => u.Email == user_em);
                newEvent.creator = logUser;
                DateTime now = DateTime.Now;
                System.Console.WriteLine("FullDT: " + newEvent.fullDT);
                System.Console.WriteLine("End DT: " + newEvent.end);
                dbContext.Add(newEvent);
                dbContext.SaveChanges();
                int id = newEvent.eventId;
                return RedirectToAction("Info", new {evId = id});
            }
            return View("New");
        }
        [Route("activity/{evId}")]
        [HttpGet]
        public IActionResult Info(int evId)
        {
            Event theEvent = dbContext.Events.Include(e => e.participants).ThenInclude(p => p.theUser).Include(e => e.creator).SingleOrDefault(e=> e.eventId == evId);
            string user_em = HttpContext.Session.GetString("email");
            User logUser = dbContext.Users.SingleOrDefault(u => u.Email == user_em);
            ActVM info = new ActVM()
            {
                thisEvent = theEvent,
                thisUser = logUser
            };
            return View("Activity", info);
        }

        [Route("join/{evId}")]
        [HttpGet]
        public IActionResult joinEv(int evId)
        {
            System.Console.WriteLine("Trying to join");
            Event thisEvent = dbContext.Events.SingleOrDefault(e => e.eventId == evId);
            string user_em = HttpContext.Session.GetString("email");
            User logUser = dbContext.Users.SingleOrDefault(u => u.Email == user_em);
            System.Console.WriteLine(thisEvent.title);
            System.Console.WriteLine(logUser.fName);
            Participant thisPart = new Participant()
            {
                userId = logUser.UserId,
                eventId = thisEvent.eventId
            };
            dbContext.Add(thisPart);
            dbContext.SaveChanges();
            return RedirectToAction("Home");
        }
        
        [Route("delete/{evId}")]
        [HttpGet]
        public IActionResult Delete(int evId)
        {
            Event thisEvent = dbContext.Events.Include(e => e.creator).SingleOrDefault(e => e.eventId == evId);
            string user_em = HttpContext.Session.GetString("email");
            User logUser = dbContext.Users.SingleOrDefault(u => u.Email == user_em);
            if(thisEvent.creator.UserId == logUser.UserId)
            {
                dbContext.Remove(thisEvent);
                dbContext.SaveChanges();
                return RedirectToAction("Home");
            }
            else
            {
                return RedirectToAction("Home");
            }
        }

        [Route("leave/{evId}")]
        [HttpGet]
        public IActionResult Leave(int evId)
        {
            Event thisEvent = dbContext.Events.Include(e => e.creator).SingleOrDefault(e => e.eventId == evId);
            string user_em = HttpContext.Session.GetString("email");
            User logUser = dbContext.Users.SingleOrDefault(u => u.Email == user_em);
            Participant join = dbContext.Participants.SingleOrDefault(j => j.eventId == thisEvent.eventId && j.userId == logUser.UserId);
            dbContext.Participants.Remove(join);
            dbContext.SaveChanges();
            return RedirectToAction("Home");
        }
    }
}
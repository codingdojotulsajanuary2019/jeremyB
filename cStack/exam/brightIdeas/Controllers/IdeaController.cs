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
    public class IdeaController : Controller
    {
        private Context dbContext;
        public IdeaController(Context context)
        {
            dbContext = context;
        }

        [Route("ideas")]
        [HttpGet]
        public IActionResult Ideas()
        {
            string user_em = HttpContext.Session.GetString("email");
            User logUser = dbContext.Users.SingleOrDefault(u => u.Email == user_em);
            List<Idea> ideaList = dbContext.Ideas.Include(i => i.creator).Include(i => i.likes).ThenInclude(l => l.theUser).OrderByDescending(i => i.likes.Count()).ToList();
            IdeaVM info = new IdeaVM()
            {
                thisUser = logUser,
                allIdea = ideaList
            };
            return View(info);
        }

        [Route("ideas")]
        [HttpPost]
        public IActionResult Add(Idea newIdea)
        {
            string user_em = HttpContext.Session.GetString("email");
            User maker = dbContext.Users.SingleOrDefault(u => u.Email == user_em);
            newIdea.creator = maker;
            dbContext.Add(newIdea);
            dbContext.SaveChanges();
            return RedirectToAction("Ideas");
        }

        [Route("delete/{ideaId}")]
        [HttpGet]
        public IActionResult Del(int ideaId)
        {
            Idea thisIdea = dbContext.Ideas.Include(i=> i.creator).SingleOrDefault(i => i.ideaId == ideaId);
            string user_em = HttpContext.Session.GetString("email");
            User logUser = dbContext.Users.SingleOrDefault(u => u.Email == user_em);
            if(thisIdea.creator.UserId == logUser.UserId)
            {
                dbContext.Remove(thisIdea);
                dbContext.SaveChanges();
                return RedirectToAction("Ideas");
            }
            else
            {
                return RedirectToAction("Ideas");
            }
        }

        [Route("like/{ideaId}")]
        [HttpGet]
        public IActionResult likeIdea(int ideaId)
        {
            // ADD VALIDATION TO MAKE SURE A USER IS LOGGED IN
            Idea thisIdea = dbContext.Ideas.Include(i => i.likes).SingleOrDefault(i => i.ideaId == ideaId);
            string user_em = HttpContext.Session.GetString("email");
            if(user_em == null)
            {
                return RedirectToAction("Index","User");
            }
            User logUser = dbContext.Users.SingleOrDefault(u => u.Email == user_em);
            if(thisIdea.likes.Any(l => l.userId == logUser.UserId))
            {
                return RedirectToAction("Ideas");
            }
            Like thisLike = new Like()
            {
                userId = logUser.UserId,
                ideaId = thisIdea.ideaId
            };
            dbContext.Add(thisLike);
            dbContext.SaveChanges();
            return RedirectToAction("Ideas");
        }

        [Route("ideas/{ideaId}")]
        [HttpGet]
        public IActionResult theIdea(int ideaId)
        {
            Idea thisIdea = dbContext.Ideas.Include(i => i.creator).Include(i => i.likes).ThenInclude(l => l.theUser).SingleOrDefault(i => i.ideaId == ideaId);
            return View(thisIdea);
        }

        [Route("user/{userId}")]
        [HttpGet]
        public IActionResult theUser(int userId)
        {
            User logUser = dbContext.Users.Include(u => u.created).ThenInclude(p => p.likes).SingleOrDefault(u => u.UserId == userId);
            UserVM info = new UserVM()
            {
                thisUser = logUser,
                userLikes = dbContext.Likes.Include(l => l.theIdea).ThenInclude(i => i.creator).Where(i => i.theIdea.creator.UserId == logUser.UserId).ToList()
            };
            return View(info);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using chefDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace chefDishes.Controllers
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
            allChef list = new allChef()
            {
                chefList = dbContext.Chefs.Include(dish => dish.Dishes).ToList()
            };
            return View(list);
        }

        [Route("new")]
        [HttpGet]
        public IActionResult New()
        {
            return View("NewChef");
        }  

        [Route("new")]
        [HttpPost]
        public IActionResult Add(Chef newChef)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(newChef);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("NewChef");
            }
        }

        [Route("dishes")]
        [HttpGet]
        public IActionResult Dishes()
        {
            allDish list = new allDish()
            {
                dishList = dbContext.Dishes.Include(chef => chef.creator).ToList()
            };
            return View(list);
        }
        [Route("dishes/new")]
        [HttpGet]
        public IActionResult newDish()
        {
            AllModels chef = new AllModels()
            {
                allChefs = dbContext.Chefs.ToList()
            };
            return View(chef);
        }
        [Route("dishes/new")]
        [HttpPost]
        public IActionResult AddDish(Dish newDish)
        {
            System.Console.WriteLine("Add new dish page");
            System.Console.WriteLine(newDish);
            if(ModelState.IsValid)
            {
                System.Console.WriteLine("validations passed");
                dbContext.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("Dishes");
            }
            else
            {
                System.Console.WriteLine("validations failed");
                return RedirectToAction("newDish");
            }
        }
    }
}

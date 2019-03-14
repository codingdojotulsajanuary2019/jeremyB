using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cruDelicious.Models;

namespace cruDelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            alldishes total = new alldishes()
            {
                allDishes = dbContext.Dishes.ToList()
            };
            
            return View(total);
        }

        [HttpGet]
        [Route("new")]
        public IActionResult New()
        {
            return View();
        }
        
        [HttpPost]
        [Route("new")]
        public IActionResult Add(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("New");
            }
        }
        [HttpGet]
        [Route("{dishId}")]
        public IActionResult Info(int dishId)
        {
            Dish thisDish = dbContext.Dishes.SingleOrDefault(dish => dish.DishId == dishId);
            return View("Info", thisDish);
        }
        [HttpGet]
        [Route("/delete/{dishId}")]
        public IActionResult Delete(int dishId)
        {
            Dish thisDish = dbContext.Dishes.SingleOrDefault(dish => dish.DishId == dishId);
            dbContext.Dishes.Remove(thisDish);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("/edit/{dishId}")]
        public IActionResult Edit(int dishId)
        {
            Dish thisDish = dbContext.Dishes.SingleOrDefault(dish => dish.DishId == dishId);
            return View("Edit", thisDish);
        }
        [HttpPost]
        [Route("/update/{dishId}")]
        public IActionResult Update(int dishId, Dish newDish)
        {
            if(ModelState.IsValid)
            {
                Dish thisDish = dbContext.Dishes.SingleOrDefault(dish => dish.DishId == dishId);
                thisDish.Name = newDish.Name;
                thisDish.Chef = newDish.Chef;
                thisDish.Tastiness = newDish.Tastiness;
                thisDish.Calories = newDish.Calories;
                thisDish.Description = newDish.Description;
                thisDish.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();
                return RedirectToAction("Info", dishId);
            }
            else{
                return RedirectToAction("Edit", dishId);
            }
        }
    }
}

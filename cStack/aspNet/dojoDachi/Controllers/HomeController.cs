using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using dojoDachi.Models;

namespace dojoDachi.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {   
            string check = HttpContext.Session.GetString("message");
            System.Console.WriteLine("*********************************");
            System.Console.WriteLine(check);
            if(check == null)
            {
                System.Console.WriteLine("New session (no messages)");
                Dachi dachi = new Dachi();
                HttpContext.Session.SetObjectAsJson("myDachi", dachi);
                return View("Index", dachi);
            }
            else
            {
                System.Console.WriteLine("Updated Dachi");
                Dachi dachi = HttpContext.Session.GetObjectFromJson<Dachi>("myDachi");
                if(dachi.happy == 0 || dachi.full == 0)
                {
                    string info = "You lose!";
                    HttpContext.Session.SetString("message", info);
                }
                if(dachi.happy == 100 && dachi.energy == 100)
                {
                    string info = "You win!";
                    HttpContext.Session.SetString("message", info);
                }
                string message = HttpContext.Session.GetString("message");
                @ViewBag.Message = message;
                return View("Index", dachi);
            }
        }

        [Route("feed")]
        [HttpGet]
        public IActionResult Feed()
        {
            System.Console.WriteLine("Got to feed");
            Dachi dachi = HttpContext.Session.GetObjectFromJson<Dachi>("myDachi");
            if(dachi.meal >0)
            {
                System.Console.WriteLine("Feed attempt");
                Random food = new Random();
                int fullness = food.Next(5,11);
                dachi.meal --;
                dachi.full += fullness;
                HttpContext.Session.SetObjectAsJson("myDachi", dachi);
                string info = $"You fed Effie! Her fullness increased by {fullness}";
                HttpContext.Session.SetString("message", info);
                return RedirectToAction("Index");
            }
            else
            {
                System.Console.WriteLine("No meals left");
                string info = "You do not have any meals left to feed Effie.";
                HttpContext.Session.SetString("message", info);
                return RedirectToAction("Index");
            }
        }
        [Route("play")]
        [HttpGet]
        public IActionResult Play()
        {
            System.Console.WriteLine("Got to play");
            Dachi dachi = HttpContext.Session.GetObjectFromJson<Dachi>("myDachi");
            dachi.energy -= 5;
            Random game = new Random();
            int happiness = game.Next(5,11);
            dachi.happy += happiness;
            HttpContext.Session.SetObjectAsJson("myDachi", dachi);
            string info = $"You played with Effie! Her happiness increased by {happiness}";
            HttpContext.Session.SetString("message", info);
            return RedirectToAction("Index");
        }

        [Route("work")]
        [HttpGet]
        public IActionResult Work()
        {
            System.Console.WriteLine("Got to work");
            Dachi dachi = HttpContext.Session.GetObjectFromJson<Dachi>("myDachi");
            dachi.energy -= 5;
            Random job = new Random();
            int meals = job.Next(1,4);
            dachi.meal += meals;
            HttpContext.Session.SetObjectAsJson("myDachi", dachi);
            string info = $"Effie went to work! She earned {meals} meals.";
            HttpContext.Session.SetString("message", info);
            return RedirectToAction("Index");
        }
        [Route("sleep")]
        [HttpGet]
        public IActionResult Sleep()
        {
            System.Console.WriteLine("Got to sleep");
            Dachi dachi = HttpContext.Session.GetObjectFromJson<Dachi>("myDachi");
            dachi.energy += 15;
            dachi.full -= 5;
            dachi.happy -= 5;
            HttpContext.Session.SetObjectAsJson("myDachi", dachi);
            string info = $"Effie went to sleep! She earned gained 15 energy.";
            HttpContext.Session.SetString("message", info);
            return RedirectToAction("Index");
        }
        [Route("reset")]
        [HttpGet]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}

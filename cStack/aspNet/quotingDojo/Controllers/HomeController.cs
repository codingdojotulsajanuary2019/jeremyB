using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using quotingDojo.Models;
using System.ComponentModel.DataAnnotations;
using DbConnection;

namespace quotingDojo.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [Route("quotes")]
        [HttpGet]
        public IActionResult Quotes()
        {
            List<Dictionary<string,object>> AllQuotes = DbConnector.Query("SELECT * FROM quotes");
            ViewBag.Quotes = AllQuotes;
            return View();
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(Quote quote)
        {
            if(ModelState.IsValid)
            {
                string query = $"INSERT INTO quotes (content, author) VALUES ('{quote.content}','{quote.name}')";
                DbConnector.Execute(query);
                System.Console.WriteLine(query);
                return RedirectToAction("Quotes");
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dojoSurvey.Models;
namespace dojoSurvey
{
    public class SurveyController : Controller
    {
        //Requests
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        [Route("result")]
        public IActionResult Result(surveyResults answers)
        {   
            if(ModelState.IsValid)
            {
                return RedirectToAction("Answers", answers);
            }
            else
            {
                return View("Index");
            }
            
        }
        [Route("answers")]
        public IActionResult Answers(surveyResults answers)
        {
            return View("Result", answers);

        }
    }
}
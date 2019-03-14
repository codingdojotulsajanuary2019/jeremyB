using Microsoft.AspNetCore.Mvc;
namespace portfolioTwo
{
    public class PortController : Controller
    {
        //Requests
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("projects")]

        public IActionResult Project()
        {
            return View("Project");
        }
        [Route("contact")]
        public IActionResult Contact()
        {
            return View("Contact");
        }
    }
}
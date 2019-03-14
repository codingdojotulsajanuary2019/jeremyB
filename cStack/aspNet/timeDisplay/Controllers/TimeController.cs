using Microsoft.AspNetCore.Mvc;
namespace timeDisplay
{
    public class TimeController : Controller
    {
        //Requests
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
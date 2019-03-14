using Microsoft.AspNetCore.Mvc;
namespace razorFun
{
    public class FunController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
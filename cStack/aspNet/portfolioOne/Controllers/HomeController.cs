using Microsoft.AspNetCore.Mvc;
namespace HelloASP
{
    public class HomeController : Controller
    {
        //Requests
        [Route("")]
        public string Index()
        {
            return "This is my index.";
        }

        [Route("projects")]

        public string Project()
        {
            return "These are my projects.";
        }
        [Route("contact")]
        public string Contact()
        {
            return "This is my contact info.";
        }
    }
}
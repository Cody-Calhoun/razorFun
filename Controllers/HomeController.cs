using Microsoft.AspNetCore.Mvc;

namespace razorFun.Controllers
{

    public class HomeController : Controller
    {
        [HttpGet("")]

        public ViewResult Home()
        {
            return View();
        }
    }

}
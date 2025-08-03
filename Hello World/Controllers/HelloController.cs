using Microsoft.AspNetCore.Mvc;

namespace Hello_World.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace AssignmentsAtanga.Areas.Users.Controllers
{
    public class HomeController : Controller
    {
        [Area("Users")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

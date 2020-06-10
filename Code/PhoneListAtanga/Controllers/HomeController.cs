using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoneListAtanga.Models;

namespace PhoneListAtanga.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }

        public HomeController(ContactContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var movies = context.Contacts.Include(m => m.Note)
                .OrderBy(m => m.Name).ToList();
            return View(movies);
        }

    }
}

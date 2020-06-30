using System.Linq;
using AssignmentsAtanga.Areas.MovieList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AssignmentsAtanga.Areas.MovieList.Controllers
{
    [Area("MovieList")]
    public class HomeController : Controller
    {
        private MovieContext context { get; set; }

        public HomeController(MovieContext ctx)
        {
            context = ctx;
        }


        public IActionResult Index()
        {
            var movies = context.Movies.Include(m => m.Genre)
                .OrderBy(m => m.Name).ToList();
            return View(movies);
        }
    }
}

using System.Linq;
using AssignmentsAtanga.Areas.MovieList.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentsAtanga.Areas.MovieList.Controllers
{
    [Area("MovieList")]
    public class MovieController : Controller
    {
        private MovieContext Context { get; set; }

        public MovieController(MovieContext ctx)
        {
            Context = ctx;
        }
        [HttpGet]   
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Genres = Context.Genres.OrderBy(g => g.Name).ToList();
            return View("Edit", new Movie());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Genres = Context.Genres.OrderBy(g => g.Name).ToList();
            var movie = Context.Movies.Find(id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                if (movie.MovieId == 0)

                    Context.Movies.Add(movie);
                else
                    Context.Movies.Update(movie);
                Context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (movie.MovieId == 0) ? "Add" : "Edit";
                ViewBag.Genres = Context.Genres.OrderBy(g => g.Name).ToList();
                return View(movie);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = Context.Movies.Find(id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            Context.Movies.Remove(movie);
            Context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}

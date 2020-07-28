using AssignmentsAtanga.Areas.Olympic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AssignmentsAtanga.Areas.Olympic.Controllers
{
    [Area("Olympic")]
    public class HomeController : Controller
    {
        private CountryContext context;

        public HomeController(CountryContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index(string activeCat = "all", string activeGame = "all")
        {
            var session = new OlympicSession(HttpContext.Session);
            session.SetActiveGame(activeCat);
            session.SetActiveCat(activeGame);

            // if no count value in session, use data in cookie to restore fave teams in session 
            int? count = session.GetMyCountryCount();
            if (count == null)
            {
                var cookies = new OlympicCookies(HttpContext.Request.Cookies);
                string[] ids = cookies.GetMyCountryIds();

                List<Country> mycountries = new List<Country>();
                if (ids.Length > 0)
                    mycountries = context.Countries.Include(t => t.Game)
                        .Include(t => t.Category)
                        .Where(t => ids.Contains(t.CountryId)).ToList();
                session.SetMyCountries(mycountries);
            }
            var model = new CountryListViewModel
            {
                ActiveGame = activeGame,
                ActiveCat = activeCat,
                Games = context.Games.ToList(),
                Categories = context.Categories.ToList()
            };

            //get countries - filter by game and category
            IQueryable<Country> query = context.Countries;
            if (activeGame != "all")
                query = query.Where(t => t.Game.GameId.ToLower() == activeGame.ToLower());
            if (activeCat != "all")
                query = query.Where(t => t.Category.CategoryId.ToLower() == activeCat.ToLower());
            model.Countries = query.ToList();

            return View(model);
        }

        public IActionResult Details(string id)
        {
            var session = new OlympicSession(HttpContext.Session);
            var model = new CountryViewModel
            {
                Country = context.Countries
                    .Include(t => t.Game)
                    .Include(t => t.Category)
                    .FirstOrDefault(t => t.CountryId == id),
                ActiveCat = session.GetActiveCat(),
                ActiveGame = session.GetActiveGame()
            };
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Add(CountryViewModel model)
        {
            model.Country = context.Countries
                .Include(t => t.Game)
                .Include(t => t.Category)
                .Where(t => t.CountryId == model.Country.CountryId)
                .FirstOrDefault();

            var session = new OlympicSession(HttpContext.Session);
            var countries = session.GetMyCountries();
            countries.Add(model.Country);
            session.SetMyCountries(countries);

            var cookies = new OlympicCookies(HttpContext.Response.Cookies);
            cookies.SetMyCountrysIds(countries);

            TempData["message"] = $"{model.Country.Name} added to your favorites";

            return RedirectToAction("Index",
                new
                {
                    ActiveGame = session.GetActiveGame(),
                    ActiveCat = session.GetActiveCat()
                });
        }
    }
}

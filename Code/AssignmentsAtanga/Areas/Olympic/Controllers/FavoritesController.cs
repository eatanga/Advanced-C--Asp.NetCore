using AssignmentsAtanga.Areas.Olympic.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentsAtanga.Areas.Olympic.Controllers
{
    [Area("Olympic")]
    public class FavoritesController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            var session = new OlympicSession(HttpContext.Session);
            var model = new CountryListViewModel
            {
                ActiveGame = session.GetActiveGame(),
                ActiveCat = session.GetActiveCat(),
                Countries = session.GetMyCountries(),
                UserName = session.GetName()
            };

            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Delete()
        {
            var session = new OlympicSession(HttpContext.Session);
            var cookies = new OlympicCookies(HttpContext.Response.Cookies);

            session.RemoveMyCountries();
            cookies.RemoveMyCountrysIds();

            TempData["message"] = "Favorite Countries cleared";

            return RedirectToAction("Index", "Home",
                new
                {
                    ActiveCat = session.GetActiveCat(),
                    ActiveGame = session.GetActiveGame()
                });
        }
    }
}

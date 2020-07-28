using AssignmentsAtanga.Areas.Olympic.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentsAtanga.Areas.Olympic.Controllers
{
    [Area("Olympic")]
    public class NameController : Controller
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
        public RedirectToActionResult Change(CountryListViewModel model)
        {
            var session = new OlympicSession(HttpContext.Session);
            session.SetName(model.UserName);
            return RedirectToAction("Index", "Home", new
            {
                ActiveCat = session.GetActiveCat(),
                ActiveGame = session.GetActiveGame()
            });
        }
    }
}

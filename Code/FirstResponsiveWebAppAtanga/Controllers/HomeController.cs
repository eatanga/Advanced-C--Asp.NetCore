using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstResponsiveWebAppAtanga.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstResponsiveWebAppAtanga.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
          
            ViewBag.FV = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(AgeDisplayModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FV = model.AgeThisYear();
                ViewBag.Name = model.Name;
            }
            else
            {
                ViewBag.FV = 0;
            }
            return View(model);
        }
    }
}

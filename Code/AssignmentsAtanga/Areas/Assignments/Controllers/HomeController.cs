using System.Linq;
using AssignmentsAtanga.Areas.Assignments.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentsAtanga.Areas.Assignments.Controllers
{
    [Area("Assignments")]
    public class HomeController : Controller
    {
        private StudentContext context { get; set; }

        public HomeController(StudentContext ctx)
        {
            context = ctx;
        }
        
        public IActionResult Index()
        {
            var students = context.Students
                 .OrderBy(m => m.FirstName).ToList();
            return View(students);
        }
    }
}

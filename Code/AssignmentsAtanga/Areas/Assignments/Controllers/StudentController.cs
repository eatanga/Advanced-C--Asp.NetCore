using AssignmentsAtanga.Areas.Assignments.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentsAtanga.Areas.Assignments.Controllers
{
    [Area("Assignments")]
    public class StudentController : Controller
    {
        private StudentContext Context { get; set; }

        public StudentController(StudentContext ctx)
        {
            Context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Student());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var student = Context.Students.Find(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                if (student.StudentId == 0)

                    Context.Students.Add(student);
                else
                    Context.Students.Update(student);
                Context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (student.StudentId == 0) ? "Add" : "Edit";
                return View(student);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = Context.Students.Find(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Delete(Student student)
        {
            Context.Students.Remove(student);
            Context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}

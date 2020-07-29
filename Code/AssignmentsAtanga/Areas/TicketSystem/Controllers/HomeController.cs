using System;
using System.Linq;
using AssignmentsAtanga.Areas.TicketSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AssignmentsAtanga.Areas.TicketSystem.Controllers
{
    [Area("TicketSystem")]
    public class HomeController : Controller
    {
        private TicketContext context;
        public HomeController(TicketContext ctx) => context = ctx;

        public IActionResult Index(string id)
        {
            //store current filters and data needed for filter drop downs in TicketViewModel
            TicketViewModel model = new TicketViewModel();

            var filters = new Filters(id);

            model.Filters = new Filters(id);
            model.Statuses = context.Statuses.ToList();
            model.DueFilters = Filters.DueFilterValues;


            // get Ticket objects from database based on current filters
            IQueryable<Ticket> query = context.Tickets
                .Include(t => t.Status);
            if (filters.HasStatus)
            {
                query = query.Where(t => t.StatusId == filters.StatusId);
            }
            if (filters.HasDue)
            {
                var today = DateTime.Today;
                if (filters.IsPast)
                    query = query.Where(t => t.DueDate < today);
                else if (filters.IsFuture)
                    query = query.Where(t => t.DueDate > today);
                else if (filters.IsToday)
                    query = query.Where(t => t.DueDate == today);
            }
            var tickets = query.OrderBy(t => t.DueDate).ToList();

            model.Tickets = tickets;
            return View(model);
        }

        public IActionResult Add()
        {
            TicketViewModel model = new TicketViewModel();
            model.Statuses = context.Statuses.ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(TicketViewModel model)
        {
            if (ModelState.IsValid)
            {
                context.Tickets.Add(model.CurrentTicket);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                model.Statuses = context.Statuses.ToList();
                return View(model);
            }
        }

        [HttpPost]
        public IActionResult Filter(string[] filter)
        {
            string id = string.Join('-', filter);
            return RedirectToAction("Index", new { ID = id });
        }

        [HttpPost]
        public IActionResult Edit([FromRoute] string id, Ticket selected)
        {
            if (selected.StatusId == null)
            {
                context.Tickets.Remove(selected);
            }
            else
            {
                string newStatusId = selected.StatusId;
                selected = context.Tickets.Find(selected.Id);
                selected.StatusId = newStatusId;
                context.Tickets.Update(selected);
            }
            context.SaveChanges();

            return RedirectToAction("Index", new { ID = id });
        }
    }
}

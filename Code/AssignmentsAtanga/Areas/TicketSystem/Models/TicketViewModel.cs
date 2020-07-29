using System.Collections.Generic;

namespace AssignmentsAtanga.Areas.TicketSystem.Models
{
    public class TicketViewModel
    {
        public TicketViewModel()
        {
            CurrentTicket = new Ticket();
        }
        public Filters Filters { get; set; }
        public List<Status> Statuses { get; set; }

        public Dictionary<string, string> DueFilters { get; set; }

        public List<Ticket> Tickets { get; set; }

        public Ticket CurrentTicket { get; set; }  //used for Add
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace AssignmentsAtanga.Areas.TicketSystem.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a ticket name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter a due date.")]
        public DateTime? DueDate { get; set; }

        [Required(ErrorMessage = "Please enter a sprintNumber")]
        public int? SprintNumber { get; set; }

        [Required(ErrorMessage = "Please enter a point value")]
        public int? PointValue { get; set; }

        [Required(ErrorMessage = "Please select a status.")]
        public string StatusId { get; set; }
        public Status Status { get; set; }

        public bool Overdue => StatusId == "open" && DueDate < DateTime.Today;
    }
}

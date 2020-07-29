using Microsoft.EntityFrameworkCore;

namespace AssignmentsAtanga.Areas.TicketSystem.Models
{
    public class TicketContext : DbContext
    {
        public TicketContext(DbContextOptions<TicketContext> options)
           : base(options) { }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = "open", Name = "To Do" },
                new Status { StatusId = "ip", Name = "In Progress" },
                new Status { StatusId = "qa", Name = "Quality Assurance" },
                new Status { StatusId = "closed", Name = "Done" }
            );
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace AssignmentsAtanga.Areas.Assignments.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                    new Student { StudentId = 1, FirstName = "John", LastName = "Emeka", Grade = "A" },
                    new Student { StudentId = 2, FirstName = "Peter", LastName = "Oniocha", Grade = "B" },
                    new Student { StudentId = 3, FirstName = "Frank", LastName = "Eneigho", Grade = "A" },
                    new Student { StudentId = 4, FirstName = "Hamlet", LastName = "Ngong", Grade = "C" },
                    new Student { StudentId = 5, FirstName = "Mark", LastName = "Jacob", Grade = "A" },
                    new Student { StudentId = 6, FirstName = "Luke", LastName = "Marshall", Grade = "B" },
                    new Student { StudentId = 7, FirstName = "James", LastName = "Tyshawn", Grade = "B" },
                    new Student { StudentId = 8, FirstName = "Richard", LastName = "Roberts", Grade = "C" },
                    new Student { StudentId = 9, FirstName = "Philip", LastName = "Grace", Grade = "A" });

        }
    }
}

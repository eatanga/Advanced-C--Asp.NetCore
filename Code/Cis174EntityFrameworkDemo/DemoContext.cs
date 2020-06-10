using Cis174EntityFrameworkDemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cis174EntityFrameworkDemo
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {

        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(@"Server=tcp:cis174atanga.database.windows.net,1433;Initial Catalog=cis174demo;Persist Security Info=False;User ID=cis174;Password=Emmanuel7;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }
}

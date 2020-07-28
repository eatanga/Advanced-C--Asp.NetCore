using Microsoft.EntityFrameworkCore;

namespace AssignmentsAtanga.Areas.Olympic.Models
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options) : base(options)
        {

        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId ="indoor", Name="Indoor"},
                new Category { CategoryId = "outdoor", Name ="Outdoor"}
                );

            modelBuilder.Entity<Game>().HasData(
                new Game { GameId = "winter", Name = "Winter Olympics" },
                new Game { GameId = "Summer", Name = "Summer Olympics" },
                new Game { GameId = "Para", Name = "Paralympics" },
                new Game { GameId = "Youth", Name = "Youth Olympic Games" }
                );

            modelBuilder.Entity<Country>().HasData(
                    new  { CountryId = "can", Name = "Canada", GameId = "Winter", CategoryId = "indoor", photopath = "CAN.png" },
                    new  { CountryId = "Swe", Name = "Sweden", GameId = "Winter", CategoryId = "indoor", photopath = "SWE.png" },
                    new  { CountryId = "gb", Name = "Great Britain", GameId = "Winter", CategoryId = "indoor", photopath = "GB.png" },
                    new  { CountryId = "jam", Name = "Jamaica", GameId = "Winter", CategoryId = "outdoor", photopath = "JAM.png" },
                    new  { CountryId = "ita", Name = "Italy", GameId = "Winter", CategoryId = "outdoor", photopath = "ITA.png" },
                    new  { CountryId = "jap", Name = "Japan", GameId = "Winter", CategoryId = "outdoor", photopath = "JAP.png" },
                    new  { CountryId = "ger", Name = "Germany", GameId = "Summer ", CategoryId = "indoor", photopath = "GER.png" },
                    new  { CountryId = "Chi", Name = "China", GameId = "Summer ", CategoryId = "indoor", photopath = "CHI.png" },
                    new  { CountryId = "mex", Name = "Mexico", GameId = "Summer", CategoryId = "indoor", photopath = "MEX.png" },
                    new  { CountryId = "bra", Name = "Brazil", GameId = "Summer", CategoryId = "outdoor", photopath = "BRA.png" },
                    new  { CountryId = "neth", Name = "Netherlands", GameId = "Summer", CategoryId = "outdoor", photopath = "NETH.png" },
                    new  { CountryId = "usa", Name = "USA", GameId = "Summer", CategoryId = "outdoor", photopath = "USA.png" },
                    new  { CountryId = "thai", Name = "Thailand", GameId = "Para", CategoryId = "indoor", photopath = "THAI.png" },
                    new  { CountryId = "uru", Name = "Uruguay", GameId = "Para", CategoryId = "indoor", photopath = "URU.png" },
                    new  { CountryId = "ukr", Name = "Ukraine", GameId = "Para", CategoryId = "indoor", photopath = "UKR.png" },
                    new  { CountryId = "aus", Name = "Austria", GameId = "Para", CategoryId = "outdoor", photopath = "AUS.png" },
                    new  { CountryId = "pak", Name = "Pakistan", GameId = "Para", CategoryId = "outdoor", photopath = "PAK.png" },
                    new  { CountryId = "zim", Name = "Zimbabwe", GameId = "Para", CategoryId = "outdoor", photopath = "ZIM.png" },
                    new  { CountryId = "fra", Name = "France", GameId = "Youth", CategoryId = "indoor", photopath = "FRA.png" },
                    new  { CountryId = "cyp", Name = "Cyprus", GameId = "Youth", CategoryId = "indoor", photopath = "CYP.png" },
                    new  { CountryId = "rus", Name = "Russia", GameId = "Youth", CategoryId = "indoor", photopath = "RUS.png" },
                    new  { CountryId = "fin", Name = "Finland", GameId = "Youth", CategoryId = "outdoor", photopath = "FIN.png" },
                    new  { CountryId = "slov", Name = "Slovakia", GameId = "Youth", CategoryId = "outdoor", photopath = "SLOV.png" },
                    new  { CountryId = "port", Name = "Portugal", GameId = "Youth", CategoryId = "outdoor", photopath = "PORT.png" });
        }
    }
}

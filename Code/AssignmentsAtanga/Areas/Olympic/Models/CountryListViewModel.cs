using System.Collections.Generic;

namespace AssignmentsAtanga.Areas.Olympic.Models
{
    public class CountryListViewModel : CountryViewModel
    {
        public string UserName { get; set; }
        public List<Country> Countries { get; set; }

        // use full properties for Game and Category 
        // so can add 'All' item at beginning
        private List<Game> games;
        public List<Game> Games
        {
            get => games;
            set
            {
                games = new List<Game> {
                    new Game { GameId = "all", Name = "All" }
                };
                games.AddRange(value);
            }
        }

        private List<Category> categories;
        public List<Category> Categories
        {
            get => categories;
            set
            {
                categories = new List<Category> {
                    new Category { CategoryId = "all", Name = "All" }
                };
                categories.AddRange(value);
            }
        }

        // methods to help view determine active link
        public string CheckActiveGame(string g) =>
            g.ToLower() == ActiveGame.ToLower() ? "active" : "";
        public string CheckActiveCat(string c) =>
            c.ToLower() == ActiveCat.ToLower() ? "active" : "";

    }
}

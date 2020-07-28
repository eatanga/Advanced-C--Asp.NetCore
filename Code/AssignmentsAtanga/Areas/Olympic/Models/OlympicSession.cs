using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace AssignmentsAtanga.Areas.Olympic.Models
{
    public class OlympicSession
    {
        private const string CountrysKey = "mycountries";
        private const string CountKey = "countrycount";
        private const string GameKey = "game";
        private const string CatKey = "cat";
        private const string NameKey = "name";

        private ISession session { get; set; }
        public OlympicSession(ISession session)
        {
            this.session = session;
        }

        public void SetMyCountries(List<Country> countries)
        {
            session.SetObject(CountrysKey, countries);
            session.SetInt32(CountKey, countries.Count);
        }
        public List<Country> GetMyCountries() =>
            session.GetObject<List<Country>>(CountrysKey) ?? new List<Country>();
        public int? GetMyCountryCount() => session.GetInt32(CountKey);

        public void SetName(string userName = "friend")
        {
            session.SetString(NameKey, userName);
        }
        public string GetName() => session.GetString(NameKey);

        public void SetActiveGame(string game) =>
            session.SetString(GameKey, game);
        public string GetActiveGame() => session.GetString(GameKey);

        public void SetActiveCat(string category) =>
            session.SetString(CatKey, category);
        public string GetActiveCat() => session.GetString(CatKey);

        public void RemoveMyCountries()
        {
            session.Remove(CountrysKey);
            session.Remove(CountKey);
        }
    }
}

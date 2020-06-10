using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppAtanga.Models
{
    public class AgeDisplayModel
    {
        const int THIS_YEAR = 2020;
        [Required(ErrorMessage = "Please enter a Name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a Birth Year.")]
        [Range(1920,2019, ErrorMessage ="Enter a birth year between 1920 and 2019.")]
        public int? BirthYear { get; set; }
        public int AgeThisYear()
        {
            int ageThisYear = THIS_YEAR - BirthYear.Value;
            return ageThisYear;
        }

    }
}

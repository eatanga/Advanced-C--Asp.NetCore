using System.ComponentModel.DataAnnotations;

namespace AssignmentsAtanga.Areas.Olympic.Models
{
    public class Country
    {
        public string CountryId { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Please enter country's name")]
        public string Name { get; set; }

        [StringLength(25)]
        [Required(ErrorMessage = "Please enter game")]
        public Game Game { get; set; }

        [StringLength(15)]
        [Required(ErrorMessage = "Please enter category")]
        public Category Category { get; set; }

        public string photopath { get; set; }
        public string Slug => Name?.Replace(' ', '-').ToLower() + '-' + Category?.ToString();
    }
}

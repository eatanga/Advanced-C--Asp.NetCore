using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cis174EntityFrameworkDemo.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }

        public int RecipeId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public decimal Quantity { get; set; }

        [StringLength(12)]
        public string Unit { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
    }
}

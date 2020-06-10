using System;
using System.ComponentModel.DataAnnotations;

namespace Cis174EntityFrameworkDemo.Entities
{
    public class Recipe
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public TimeSpan TimeToCook { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(1024)]
        public string Method { get; set; }
    }
}

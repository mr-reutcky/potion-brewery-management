using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potion_brewery_management.Models {
    public class Ingredient {
        public int Id { get; set; }

        public string Name { get; set; }

        public int QuantityInStock { get; set; }

        public int MinimumStockThreshold { get; set; }

        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }

}

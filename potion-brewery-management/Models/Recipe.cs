using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potion_brewery_management.Models {
    public class Recipe {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int BrewingTimeInSeconds { get; set; }

        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }

        public ICollection<BrewedPotion> BrewedPotions { get; set; }
    }

}

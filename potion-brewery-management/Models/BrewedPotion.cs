using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potion_brewery_management.Models {
    public class BrewedPotion {
        public int Id { get; set; }

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }

        public string CustomName { get; set; }

        public string Attributes { get; set; } // You can store things like "Healing +5, Red Glow"

        public DateTime BrewedAt { get; set; }
    }

}

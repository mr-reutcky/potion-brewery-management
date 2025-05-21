using potion_brewery_management.Models;

namespace potion_brewery_management {
    public partial class ReportsForm : Form {
        private BreweryDbContext _context;

        public ReportsForm() {
            InitializeComponent();
            _context = new BreweryDbContext();
            LoadReports();
        }

        private void LoadReports() {
            // Load all ingredients
            List<Ingredient> ingredients = _context.Ingredients.ToList();
            lstIngredients.DataSource = ingredients;
            lstIngredients.DisplayMember = "Name";

            // Determine the most used recipe
            List<Recipe> allRecipes = _context.Recipes.ToList();
            Dictionary<int, int> recipeUsage = new Dictionary<int, int>();

            foreach (Recipe recipe in allRecipes) {
                int count = _context.BrewedPotions.Count(p => p.RecipeId == recipe.Id);
                recipeUsage[recipe.Id] = count;
            }

            Recipe mostUsed = recipeUsage
                .OrderByDescending(kvp => kvp.Value)
                .Select(kvp => allRecipes.First(r => r.Id == kvp.Key))
                .FirstOrDefault();

            if (mostUsed != null) {
                txtMostUsedRecipe.Text = mostUsed.Name;
            }
            else {
                txtMostUsedRecipe.Text = "No potions brewed yet.";
            }
        }
    }
}

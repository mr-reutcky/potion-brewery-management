using System.Data;
using potion_brewery_management.Models;

namespace potion_brewery_management.Forms {
    public partial class RecipeManagementForm : Form {
        private BreweryDbContext _context;
        private List<RecipeIngredient> _currentIngredients;

        public RecipeManagementForm() {
            InitializeComponent();

            btnAddIngredient.Click += btnAddIngredient_Click;
            btnSaveRecipe.Click += btnSaveRecipe_Click;
            btnDeleteRecipe.Click += btnDeleteRecipe_Click;
            btnClearForm.Click += btnClearForm_Click;
            lstRecipes.SelectedIndexChanged += lstRecipes_SelectedIndexChanged;

            _context = new BreweryDbContext();
            _currentIngredients = new List<RecipeIngredient>();

            LoadIngredients();
            LoadRecipes();
        }

        private void LoadIngredients() {
            List<Ingredient> ingredients = _context.Ingredients.ToList();
            cmbIngredient.DataSource = ingredients;
            cmbIngredient.DisplayMember = "Name";
            cmbIngredient.ValueMember = "Id";
        }

        private void LoadRecipes() {
            lstRecipes.DataSource = null;
            lstRecipes.DataSource = _context.Recipes.ToList();
            lstRecipes.DisplayMember = "Name";
        }

        private void btnAddIngredient_Click(object sender, EventArgs e) {
            Ingredient selected = cmbIngredient.SelectedItem as Ingredient;
            if (selected == null) {
                MessageBox.Show("Please select an ingredient.");
                return;
            }

            int quantity = (int)numIngredientQty.Value;
            if (quantity <= 0) {
                MessageBox.Show("Quantity must be greater than 0.");
                return;
            }

            RecipeIngredient existing = _currentIngredients
                .FirstOrDefault(x => x.IngredientId == selected.Id);

            if (existing != null) {
                existing.QuantityRequired += quantity;
            }
            else {
                _currentIngredients.Add(new RecipeIngredient {
                    IngredientId = selected.Id,
                    Ingredient = selected,
                    QuantityRequired = quantity
                });
            }

            RefreshIngredientGrid();
        }

        private void RefreshIngredientGrid() {
            dgvIngredients.DataSource = null;
            dgvIngredients.DataSource = _currentIngredients
                .Select(i => new {
                    Ingredient = i.Ingredient.Name,
                    Quantity = i.QuantityRequired
                }).ToList();
        }

        private void btnSaveRecipe_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtRecipeName.Text)) {
                MessageBox.Show("Please enter a recipe name.");
                return;
            }

            Recipe newRecipe = new Recipe {
                Name = txtRecipeName.Text.Trim(),
                Description = txtRecipeDescription.Text.Trim(),
                BrewingTimeInSeconds = (int)numBrewingTime.Value,
                RecipeIngredients = new List<RecipeIngredient>()
            };

            foreach (RecipeIngredient ri in _currentIngredients) {
                newRecipe.RecipeIngredients.Add(new RecipeIngredient {
                    IngredientId = ri.IngredientId,
                    QuantityRequired = ri.QuantityRequired
                });
            }

            _context.Recipes.Add(newRecipe);
            _context.SaveChanges();

            MessageBox.Show("Recipe saved successfully!");
            ClearForm();
            LoadRecipes();
        }

        private void btnDeleteRecipe_Click(object sender, EventArgs e) {
            Recipe selected = lstRecipes.SelectedItem as Recipe;
            if (selected == null) {
                MessageBox.Show("Select a recipe to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete '{selected.Name}'?",
                "Confirm Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) {
                _context.Recipes.Remove(selected);
                _context.SaveChanges();
                MessageBox.Show("Recipe deleted.");
                ClearForm();
                LoadRecipes();
            }
        }

        private void lstRecipes_SelectedIndexChanged(object sender, EventArgs e) {
            Recipe selected = lstRecipes.SelectedItem as Recipe;
            if (selected == null) {
                return;
            }

            txtRecipeName.Text = selected.Name;
            txtRecipeDescription.Text = selected.Description;
            numBrewingTime.Value = selected.BrewingTimeInSeconds;

            _currentIngredients = _context.RecipeIngredients
                .Where(ri => ri.RecipeId == selected.Id)
                .ToList();

            foreach (RecipeIngredient ri in _currentIngredients) {
                ri.Ingredient = _context.Ingredients.FirstOrDefault(i => i.Id == ri.IngredientId);
            }

            RefreshIngredientGrid();
        }

        private void btnClearForm_Click(object sender, EventArgs e) {
            ClearForm();
        }

        private void ClearForm() {
            txtRecipeName.Clear();
            txtRecipeDescription.Clear();
            numBrewingTime.Value = 0;
            _currentIngredients.Clear();
            RefreshIngredientGrid();
            lstRecipes.ClearSelected();
        }
    }
}

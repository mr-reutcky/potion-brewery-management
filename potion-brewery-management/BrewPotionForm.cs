using Microsoft.EntityFrameworkCore;
using potion_brewery_management.Models;

namespace potion_brewery_management {
    public partial class BrewPotionForm : Form {
        private BreweryDbContext _dbContext;

        public BrewPotionForm() {
            InitializeComponent();
            _dbContext = new BreweryDbContext();

            Load += BrewPotionForm_Load;

            btnBrew.Click += btnBrew_Click;
        }

        private void BrewPotionForm_Load(object sender, EventArgs e) {
            LoadRecipes();
            LoadBrewedPotions();
        }

        private void LoadRecipes() {
            var recipes = _dbContext.Recipes.ToList();
            cmbRecipes.DataSource = recipes;
            cmbRecipes.DisplayMember = "Name";
            cmbRecipes.ValueMember = "Id";
        }

        private void LoadBrewedPotions() {
            var brewedPotions = _dbContext.BrewedPotions
                .Include(bp => bp.Recipe)
                .Select(bp => new {
                    bp.Id,
                    RecipeName = bp.Recipe.Name,
                    CustomName = bp.CustomName,
                    bp.Attributes,
                    BrewedAt = bp.BrewedAt.ToString("g")
                })
                .ToList();

            dgvBrewedPotions.DataSource = brewedPotions;
            dgvBrewedPotions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBrewedPotions.ReadOnly = true;
            dgvBrewedPotions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnBrew_Click(object sender, EventArgs e) {
            if (cmbRecipes.SelectedItem is Recipe selectedRecipe) {
                string customName = txtCustomName.Text.Trim();
                string attributes = txtAttributes.Text.Trim();

                BrewedPotion newPotion = new BrewedPotion {
                    RecipeId = selectedRecipe.Id,
                    CustomName = string.IsNullOrEmpty(customName) ? null : customName,
                    Attributes = attributes,
                    BrewedAt = DateTime.Now
                };

                _dbContext.BrewedPotions.Add(newPotion);
                _dbContext.SaveChanges();

                lblResult.Text = $"✅ Brewed: {(newPotion.CustomName ?? selectedRecipe.Name)} at {newPotion.BrewedAt:t}";
                lblResult.ForeColor = System.Drawing.Color.Green;

                txtCustomName.Clear();
                txtAttributes.Clear();

                LoadBrewedPotions();
            }
            else {
                lblResult.Text = "❌ Please select a recipe.";
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}

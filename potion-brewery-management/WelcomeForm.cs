using System;
using System.Windows.Forms;

namespace potion_brewery_management {
    public partial class WelcomeForm : Form {
        public WelcomeForm() {
            InitializeComponent();
        }

        private void btnRecipeManagement_Click(object sender, EventArgs e) {
            RecipeManagementForm recipeForm = new RecipeManagementForm();
            recipeForm.ShowDialog();
        }

        private void btnIngredientManagement_Click(object sender, EventArgs e) {
            IngredientManagementForm ingredientForm = new IngredientManagementForm();
            ingredientForm.ShowDialog();
        }

        private void btnBrewPotion_Click(object sender, EventArgs e) {
            BrewPotionForm brewForm = new BrewPotionForm();
            brewForm.ShowDialog();
        }

        private void btnReportsForm_Click(object sender, EventArgs e) {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.ShowDialog();
        }
    }
}

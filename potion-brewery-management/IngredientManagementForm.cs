using potion_brewery_management.Models;

namespace potion_brewery_management
{
    public partial class IngredientManagementForm : Form {
        private BreweryDbContext _context;  

        public IngredientManagementForm() {
            InitializeComponent();

            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.dgvIngredients.SelectionChanged += new System.EventHandler(this.dgvIngredients_SelectionChanged);

            _context = new BreweryDbContext();
            LoadIngredients();
        }

        private void LoadIngredients() {
            List<Ingredient> ingredients = _context.Ingredients.ToList();
            dgvIngredients.DataSource = null;
            dgvIngredients.DataSource = ingredients;

            foreach (DataGridViewRow row in dgvIngredients.Rows) {
                Ingredient ingredient = row.DataBoundItem as Ingredient;
                if (ingredient != null && ingredient.QuantityInStock < ingredient.MinimumStockThreshold) {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }
                else {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            Ingredient newIngredient = new Ingredient();
            newIngredient.Name = txtName.Text;
            newIngredient.QuantityInStock = Convert.ToInt32(numQuantity.Value);
            newIngredient.MinimumStockThreshold = Convert.ToInt32(numMinStock.Value);

            if (string.IsNullOrWhiteSpace(newIngredient.Name)) {
                MessageBox.Show("Please enter a valid ingredient name.");
                return;
            }

            if (newIngredient.QuantityInStock < 0 || newIngredient.MinimumStockThreshold < 0) {
                MessageBox.Show("Quantity and Minimum Stock Threshold must be non-negative.");
                return;
            }

            if (newIngredient.QuantityInStock < newIngredient.MinimumStockThreshold) {
                MessageBox.Show("Quantity in stock cannot be less than the minimum stock threshold.");
                return;
            }
            _context.Ingredients.Add(newIngredient);
            _context.SaveChanges();
            LoadIngredients();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            if (dgvIngredients.CurrentRow != null && dgvIngredients.CurrentRow.DataBoundItem is Ingredient selectedIngredient) {
                selectedIngredient.Name = txtName.Text;
                selectedIngredient.QuantityInStock = Convert.ToInt32(numQuantity.Value);
                selectedIngredient.MinimumStockThreshold = Convert.ToInt32(numMinStock.Value);


                if (string.IsNullOrWhiteSpace(selectedIngredient.Name)) {
                    MessageBox.Show("Please enter a valid ingredient name.");
                    return;
                }

                if (selectedIngredient.QuantityInStock < 0 || selectedIngredient.MinimumStockThreshold < 0) {
                    MessageBox.Show("Quantity and Minimum Stock Threshold must be non-negative.");
                    return;
                }

                if (selectedIngredient.QuantityInStock < selectedIngredient.MinimumStockThreshold) {
                    MessageBox.Show("Quantity in stock cannot be less than the minimum stock threshold.");
                    return;
                }

                _context.SaveChanges();
                LoadIngredients();
                ClearInputs();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (dgvIngredients.CurrentRow != null && dgvIngredients.CurrentRow.DataBoundItem is Ingredient selectedIngredient) {
                _context.Ingredients.Remove(selectedIngredient);
                _context.SaveChanges();
                LoadIngredients();
                ClearInputs();
            }
        }

        private void dgvIngredients_SelectionChanged(object sender, EventArgs e) {
            if (dgvIngredients.CurrentRow != null && dgvIngredients.CurrentRow.DataBoundItem is Ingredient selectedIngredient) {
                txtName.Text = selectedIngredient.Name;
                numQuantity.Value = selectedIngredient.QuantityInStock;
                numMinStock.Value = selectedIngredient.MinimumStockThreshold;
            }
        }

        private void ClearInputs() {
            txtName.Text = "";
            numQuantity.Value = 0;
            numMinStock.Value = 0;
        }

        private void label3_Click(object sender, EventArgs e) {

        }
    }
}

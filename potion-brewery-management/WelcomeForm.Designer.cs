namespace potion_brewery_management {
    partial class WelcomeForm {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            lblWelcome = new Label();
            btnRecipeManagement = new Button();
            btnIngredientManagement = new Button();
            btnBrewPotion = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblWelcome.Location = new Point(30, 10);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(550, 30);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to the Potion Brewery!";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRecipeManagement
            // 
            btnRecipeManagement.Location = new Point(198, 130);
            btnRecipeManagement.Name = "btnRecipeManagement";
            btnRecipeManagement.Size = new Size(217, 40);
            btnRecipeManagement.TabIndex = 1;
            btnRecipeManagement.Text = "Recipe Management";
            btnRecipeManagement.UseVisualStyleBackColor = true;
            btnRecipeManagement.Click += btnRecipeManagement_Click;
            // 
            // btnIngredientManagement
            // 
            btnIngredientManagement.Location = new Point(198, 84);
            btnIngredientManagement.Name = "btnIngredientManagement";
            btnIngredientManagement.Size = new Size(217, 40);
            btnIngredientManagement.TabIndex = 2;
            btnIngredientManagement.Text = "Ingredient Management";
            btnIngredientManagement.UseVisualStyleBackColor = true;
            btnIngredientManagement.Click += btnIngredientManagement_Click;
            // 
            // btnBrewPotion
            // 
            btnBrewPotion.Location = new Point(198, 176);
            btnBrewPotion.Name = "btnBrewPotion";
            btnBrewPotion.Size = new Size(217, 40);
            btnBrewPotion.TabIndex = 3;
            btnBrewPotion.Text = "Brew Potion";
            btnBrewPotion.UseVisualStyleBackColor = true;
            btnBrewPotion.Click += btnBrewPotion_Click;
            // 
            // WelcomeForm
            // 
            ClientSize = new Size(613, 250);
            Controls.Add(btnBrewPotion);
            Controls.Add(btnIngredientManagement);
            Controls.Add(btnRecipeManagement);
            Controls.Add(lblWelcome);
            Name = "WelcomeForm";
            Text = "Potion Brewery Management";
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnRecipeManagement;
        private System.Windows.Forms.Button btnIngredientManagement;
        private System.Windows.Forms.Button btnBrewPotion;
    }
}

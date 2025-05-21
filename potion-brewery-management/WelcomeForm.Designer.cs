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
            btnReportsForm = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblWelcome.Location = new Point(126, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(550, 61);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to the Potion Brewery!";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRecipeManagement
            // 
            btnRecipeManagement.BackColor = Color.FromArgb(192, 192, 255);
            btnRecipeManagement.Location = new Point(224, 195);
            btnRecipeManagement.Name = "btnRecipeManagement";
            btnRecipeManagement.Size = new Size(337, 84);
            btnRecipeManagement.TabIndex = 1;
            btnRecipeManagement.Text = "Recipe Management";
            btnRecipeManagement.UseVisualStyleBackColor = false;
            btnRecipeManagement.Click += btnRecipeManagement_Click;
            // 
            // btnIngredientManagement
            // 
            btnIngredientManagement.BackColor = Color.FromArgb(192, 255, 192);
            btnIngredientManagement.Location = new Point(224, 105);
            btnIngredientManagement.Name = "btnIngredientManagement";
            btnIngredientManagement.Size = new Size(337, 84);
            btnIngredientManagement.TabIndex = 2;
            btnIngredientManagement.Text = "Ingredient Management";
            btnIngredientManagement.UseVisualStyleBackColor = false;
            btnIngredientManagement.Click += btnIngredientManagement_Click;
            // 
            // btnBrewPotion
            // 
            btnBrewPotion.BackColor = Color.FromArgb(255, 192, 255);
            btnBrewPotion.Location = new Point(224, 285);
            btnBrewPotion.Name = "btnBrewPotion";
            btnBrewPotion.Size = new Size(337, 84);
            btnBrewPotion.TabIndex = 3;
            btnBrewPotion.Text = "Brew Potion";
            btnBrewPotion.UseVisualStyleBackColor = false;
            btnBrewPotion.Click += btnBrewPotion_Click;
            // 
            // btnReportsForm
            // 
            btnReportsForm.BackColor = Color.FromArgb(255, 224, 192);
            btnReportsForm.Location = new Point(224, 375);
            btnReportsForm.Name = "btnReportsForm";
            btnReportsForm.Size = new Size(337, 84);
            btnReportsForm.TabIndex = 4;
            btnReportsForm.Text = "System Reports";
            btnReportsForm.UseVisualStyleBackColor = false;
            btnReportsForm.Click += btnReportsForm_Click;
            // 
            // WelcomeForm
            // 
            ClientSize = new Size(778, 504);
            Controls.Add(btnReportsForm);
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
        private Button btnReportsForm;
    }
}

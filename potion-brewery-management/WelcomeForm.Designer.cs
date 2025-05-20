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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnRecipeManagement = new System.Windows.Forms.Button();
            this.btnIngredientManagement = new System.Windows.Forms.Button();
            this.btnBrewPotion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(30, 10);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(340, 30);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Potion Brewery!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRecipeManagement
            // 
            this.btnRecipeManagement.Location = new System.Drawing.Point(100, 50);
            this.btnRecipeManagement.Name = "btnRecipeManagement";
            this.btnRecipeManagement.Size = new System.Drawing.Size(200, 40);
            this.btnRecipeManagement.TabIndex = 1;
            this.btnRecipeManagement.Text = "Recipe Management";
            this.btnRecipeManagement.UseVisualStyleBackColor = true;
            this.btnRecipeManagement.Click += new System.EventHandler(this.btnRecipeManagement_Click);
            // 
            // btnIngredientManagement
            // 
            this.btnIngredientManagement.Location = new System.Drawing.Point(100, 100);
            this.btnIngredientManagement.Name = "btnIngredientManagement";
            this.btnIngredientManagement.Size = new System.Drawing.Size(200, 40);
            this.btnIngredientManagement.TabIndex = 2;
            this.btnIngredientManagement.Text = "Ingredient Management";
            this.btnIngredientManagement.UseVisualStyleBackColor = true;
            this.btnIngredientManagement.Click += new System.EventHandler(this.btnIngredientManagement_Click);
            // 
            // btnBrewPotion
            // 
            this.btnBrewPotion.Location = new System.Drawing.Point(100, 150);
            this.btnBrewPotion.Name = "btnBrewPotion";
            this.btnBrewPotion.Size = new System.Drawing.Size(200, 40);
            this.btnBrewPotion.TabIndex = 3;
            this.btnBrewPotion.Text = "Brew Potion";
            this.btnBrewPotion.UseVisualStyleBackColor = true;
            this.btnBrewPotion.Click += new System.EventHandler(this.btnBrewPotion_Click);
            // 
            // WelcomeForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.btnBrewPotion);
            this.Controls.Add(this.btnIngredientManagement);
            this.Controls.Add(this.btnRecipeManagement);
            this.Controls.Add(this.lblWelcome);
            this.Name = "WelcomeForm";
            this.Text = "Potion Brewery Management";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnRecipeManagement;
        private System.Windows.Forms.Button btnIngredientManagement;
        private System.Windows.Forms.Button btnBrewPotion;
    }
}

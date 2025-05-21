namespace potion_brewery_management {
    partial class ReportsForm {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMostUsedRecipe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Ingredients List";
            // 
            // lstIngredients
            // 
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.ItemHeight = 15;
            this.lstIngredients.Location = new System.Drawing.Point(20, 45);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(300, 199);
            this.lstIngredients.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Most Used Recipe Name";
            // 
            // txtMostUsedRecipe
            // 
            this.txtMostUsedRecipe.Location = new System.Drawing.Point(20, 280);
            this.txtMostUsedRecipe.Name = "txtMostUsedRecipe";
            this.txtMostUsedRecipe.ReadOnly = true;
            this.txtMostUsedRecipe.Size = new System.Drawing.Size(300, 23);
            this.txtMostUsedRecipe.TabIndex = 3;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 330);
            this.Controls.Add(this.txtMostUsedRecipe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstIngredients);
            this.Controls.Add(this.label1);
            this.Name = "ReportsForm";
            this.Text = "Reports";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstIngredients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMostUsedRecipe;
    }
}

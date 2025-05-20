using System;
using System.Drawing;
using System.Windows.Forms;

namespace potion_brewery_management {
    partial class RecipeManagementForm : Form{
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            txtRecipeName = new TextBox();
            Description = new Label();
            txtRecipeDescription = new TextBox();
            numBrewingTime = new NumericUpDown();
            label2 = new Label();
            cmbIngredient = new ComboBox();
            label3 = new Label();
            numIngredientQty = new NumericUpDown();
            label4 = new Label();
            btnAddIngredient = new Button();
            dgvIngredients = new DataGridView();
            label5 = new Label();
            btnSaveRecipe = new Button();
            lstRecipes = new ListBox();
            label6 = new Label();
            btnDeleteRecipe = new Button();
            btnClearForm = new Button();
            ((System.ComponentModel.ISupportInitialize)numBrewingTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIngredientQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 30);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Recipe Name";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Location = new Point(157, 27);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(100, 23);
            txtRecipeName.TabIndex = 1;
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Location = new Point(16, 59);
            Description.Name = "Description";
            Description.Size = new Size(67, 15);
            Description.TabIndex = 2;
            Description.Text = "Description";
            // 
            // txtRecipeDescription
            // 
            txtRecipeDescription.Location = new Point(157, 56);
            txtRecipeDescription.Name = "txtRecipeDescription";
            txtRecipeDescription.Size = new Size(100, 23);
            txtRecipeDescription.TabIndex = 3;
            // 
            // numBrewingTime
            // 
            numBrewingTime.Location = new Point(137, 85);
            numBrewingTime.Name = "numBrewingTime";
            numBrewingTime.Size = new Size(120, 23);
            numBrewingTime.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 87);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 5;
            label2.Text = "Brewing Time (s)";
            // 
            // cmbIngredient
            // 
            cmbIngredient.FormattingEnabled = true;
            cmbIngredient.Location = new Point(137, 114);
            cmbIngredient.Name = "cmbIngredient";
            cmbIngredient.Size = new Size(121, 23);
            cmbIngredient.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 117);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 7;
            label3.Text = "Ingredient";
            // 
            // numIngredientQty
            // 
            numIngredientQty.Location = new Point(137, 143);
            numIngredientQty.Name = "numIngredientQty";
            numIngredientQty.Size = new Size(120, 23);
            numIngredientQty.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 145);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 9;
            label4.Text = "Quantity";
            // 
            // btnAddIngredient
            // 
            btnAddIngredient.Location = new Point(182, 181);
            btnAddIngredient.Name = "btnAddIngredient";
            btnAddIngredient.Size = new Size(75, 23);
            btnAddIngredient.TabIndex = 10;
            btnAddIngredient.Text = "ADD";
            btnAddIngredient.UseVisualStyleBackColor = true;
            // 
            // dgvIngredients
            // 
            dgvIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredients.Location = new Point(16, 235);
            dgvIngredients.Name = "dgvIngredients";
            dgvIngredients.Size = new Size(678, 150);
            dgvIngredients.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 217);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 12;
            label5.Text = "Ingredients:";
            // 
            // btnSaveRecipe
            // 
            btnSaveRecipe.BackColor = Color.FromArgb(192, 255, 192);
            btnSaveRecipe.Location = new Point(12, 402);
            btnSaveRecipe.Name = "btnSaveRecipe";
            btnSaveRecipe.Size = new Size(122, 23);
            btnSaveRecipe.TabIndex = 13;
            btnSaveRecipe.Text = "SAVE RECIPE";
            btnSaveRecipe.UseVisualStyleBackColor = false;
            // 
            // lstRecipes
            // 
            lstRecipes.FormattingEnabled = true;
            lstRecipes.ItemHeight = 15;
            lstRecipes.Location = new Point(16, 491);
            lstRecipes.Name = "lstRecipes";
            lstRecipes.Size = new Size(678, 139);
            lstRecipes.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 462);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 15;
            label6.Text = "Saved Recipes:";
            // 
            // btnDeleteRecipe
            // 
            btnDeleteRecipe.Location = new Point(18, 645);
            btnDeleteRecipe.Name = "btnDeleteRecipe";
            btnDeleteRecipe.Size = new Size(75, 23);
            btnDeleteRecipe.TabIndex = 16;
            btnDeleteRecipe.Text = "DELETE";
            btnDeleteRecipe.UseVisualStyleBackColor = true;
            // 
            // btnClearForm
            // 
            btnClearForm.BackColor = Color.FromArgb(255, 128, 128);
            btnClearForm.ForeColor = SystemColors.ActiveCaptionText;
            btnClearForm.Location = new Point(140, 402);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(120, 23);
            btnClearForm.TabIndex = 17;
            btnClearForm.Text = "CLEAR FORM";
            btnClearForm.UseVisualStyleBackColor = false;
            // 
            // RecipeManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 680);
            Controls.Add(btnClearForm);
            Controls.Add(btnDeleteRecipe);
            Controls.Add(label6);
            Controls.Add(lstRecipes);
            Controls.Add(btnSaveRecipe);
            Controls.Add(label5);
            Controls.Add(dgvIngredients);
            Controls.Add(btnAddIngredient);
            Controls.Add(label4);
            Controls.Add(numIngredientQty);
            Controls.Add(label3);
            Controls.Add(cmbIngredient);
            Controls.Add(label2);
            Controls.Add(numBrewingTime);
            Controls.Add(txtRecipeDescription);
            Controls.Add(Description);
            Controls.Add(txtRecipeName);
            Controls.Add(label1);
            Name = "RecipeManagementForm";
            Text = "Recipe Manager";
            Load += RecipeManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)numBrewingTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIngredientQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRecipeName;
        private Label Description;
        private TextBox txtRecipeDescription;
        private NumericUpDown numBrewingTime;
        private Label label2;
        private ComboBox cmbIngredient;
        private Label label3;
        private NumericUpDown numIngredientQty;
        private Label label4;
        private Button btnAddIngredient;
        private DataGridView dgvIngredients;
        private Label label5;
        private Button btnSaveRecipe;
        private ListBox lstRecipes;
        private Label label6;
        private Button btnDeleteRecipe;
        private Button btnClearForm;
    }
}
namespace potion_brewery_management {
    partial class BrewPotionForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            cmbRecipes = new ComboBox();
            label2 = new Label();
            txtCustomName = new TextBox();
            label3 = new Label();
            txtAttributes = new TextBox();
            btnBrew = new Button();
            dgvBrewedPotions = new DataGridView();
            label4 = new Label();
            lblResult = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBrewedPotions).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 25);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Recipe";
            // 
            // cmbRecipes
            // 
            cmbRecipes.FormattingEnabled = true;
            cmbRecipes.Location = new Point(99, 25);
            cmbRecipes.Name = "cmbRecipes";
            cmbRecipes.Size = new Size(121, 23);
            cmbRecipes.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 57);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // txtCustomName
            // 
            txtCustomName.Location = new Point(120, 54);
            txtCustomName.Name = "txtCustomName";
            txtCustomName.Size = new Size(100, 23);
            txtCustomName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 86);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 4;
            label3.Text = "Attributes";
            // 
            // txtAttributes
            // 
            txtAttributes.Location = new Point(120, 83);
            txtAttributes.Name = "txtAttributes";
            txtAttributes.Size = new Size(100, 23);
            txtAttributes.TabIndex = 5;
            // 
            // btnBrew
            // 
            btnBrew.Location = new Point(145, 121);
            btnBrew.Name = "btnBrew";
            btnBrew.Size = new Size(75, 23);
            btnBrew.TabIndex = 6;
            btnBrew.Text = "BREW";
            btnBrew.UseVisualStyleBackColor = true;
            // 
            // dgvBrewedPotions
            // 
            dgvBrewedPotions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBrewedPotions.Location = new Point(259, 46);
            dgvBrewedPotions.Name = "dgvBrewedPotions";
            dgvBrewedPotions.Size = new Size(529, 354);
            dgvBrewedPotions.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(259, 28);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 8;
            label4.Text = "All Potions:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(28, 160);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(39, 15);
            lblResult.TabIndex = 9;
            lblResult.Text = "Result";
            // 
            // BrewPotionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(label4);
            Controls.Add(dgvBrewedPotions);
            Controls.Add(btnBrew);
            Controls.Add(txtAttributes);
            Controls.Add(label3);
            Controls.Add(txtCustomName);
            Controls.Add(label2);
            Controls.Add(cmbRecipes);
            Controls.Add(label1);
            Name = "BrewPotionForm";
            Text = "Brew Potions";
            ((System.ComponentModel.ISupportInitialize)dgvBrewedPotions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbRecipes;
        private Label label2;
        private TextBox txtCustomName;
        private Label label3;
        private TextBox txtAttributes;
        private Button btnBrew;
        private DataGridView dgvBrewedPotions;
        private Label label4;
        private Label lblResult;
    }
}
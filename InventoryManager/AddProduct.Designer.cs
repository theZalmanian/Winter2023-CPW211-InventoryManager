namespace InventoryManager
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.grpFood = new System.Windows.Forms.GroupBox();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.txtAllergies = new System.Windows.Forms.TextBox();
            this.grpProduct.SuspendLayout();
            this.grpFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSKU
            // 
            this.txtSKU.Location = new System.Drawing.Point(11, 20);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.PlaceholderText = "SKU";
            this.txtSKU.Size = new System.Drawing.Size(129, 23);
            this.txtSKU.TabIndex = 1;
            this.txtSKU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(11, 49);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PlaceholderText = "Title";
            this.txtTitle.Size = new System.Drawing.Size(129, 23);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(11, 78);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceholderText = "Price";
            this.txtPrice.Size = new System.Drawing.Size(129, 23);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpProduct
            // 
            this.grpProduct.Controls.Add(this.txtSKU);
            this.grpProduct.Controls.Add(this.txtPrice);
            this.grpProduct.Controls.Add(this.txtTitle);
            this.grpProduct.Location = new System.Drawing.Point(12, 12);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(151, 110);
            this.grpProduct.TabIndex = 1;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Product Info";
            // 
            // grpFood
            // 
            this.grpFood.Controls.Add(this.txtCalories);
            this.grpFood.Controls.Add(this.txtAllergies);
            this.grpFood.Location = new System.Drawing.Point(12, 128);
            this.grpFood.Name = "grpFood";
            this.grpFood.Size = new System.Drawing.Size(151, 82);
            this.grpFood.TabIndex = 6;
            this.grpFood.TabStop = false;
            this.grpFood.Text = "Food Info";
            // 
            // txtCalories
            // 
            this.txtCalories.Location = new System.Drawing.Point(11, 20);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.PlaceholderText = "Calories";
            this.txtCalories.Size = new System.Drawing.Size(129, 23);
            this.txtCalories.TabIndex = 1;
            this.txtCalories.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAllergies
            // 
            this.txtAllergies.Location = new System.Drawing.Point(11, 49);
            this.txtAllergies.Name = "txtAllergies";
            this.txtAllergies.PlaceholderText = "Allergies";
            this.txtAllergies.Size = new System.Drawing.Size(129, 23);
            this.txtAllergies.TabIndex = 3;
            this.txtAllergies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 390);
            this.Controls.Add(this.grpFood);
            this.Controls.Add(this.grpProduct);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            this.grpFood.ResumeLayout(false);
            this.grpFood.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox txtSKU;
        private TextBox txtTitle;
        private TextBox txtPrice;
        private GroupBox grpProduct;
        private GroupBox grpFood;
        private TextBox txtCalories;
        private TextBox txtAllergies;
    }
}
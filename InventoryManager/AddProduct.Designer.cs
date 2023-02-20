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
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.grpProduct.SuspendLayout();
            this.grpFood.SuspendLayout();
            this.grpBook.SuspendLayout();
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
            this.grpProduct.Location = new System.Drawing.Point(39, 12);
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
            this.grpFood.Location = new System.Drawing.Point(39, 157);
            this.grpFood.Name = "grpFood";
            this.grpFood.Size = new System.Drawing.Size(151, 82);
            this.grpFood.TabIndex = 6;
            this.grpFood.TabStop = false;
            this.grpFood.Text = "Food Info";
            this.grpFood.Visible = false;
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
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(50, 128);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(129, 23);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // grpBook
            // 
            this.grpBook.Controls.Add(this.txtISBN);
            this.grpBook.Controls.Add(this.txtAuthor);
            this.grpBook.Location = new System.Drawing.Point(39, 245);
            this.grpBook.Name = "grpBook";
            this.grpBook.Size = new System.Drawing.Size(151, 82);
            this.grpBook.TabIndex = 8;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Book Info";
            this.grpBook.Visible = false;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(11, 20);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.PlaceholderText = "ISBN";
            this.txtISBN.Size = new System.Drawing.Size(129, 23);
            this.txtISBN.TabIndex = 1;
            this.txtISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(11, 49);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.PlaceholderText = "Author";
            this.txtAuthor.Size = new System.Drawing.Size(129, 23);
            this.txtAuthor.TabIndex = 3;
            this.txtAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 340);
            this.Controls.Add(this.grpBook);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.grpFood);
            this.Controls.Add(this.grpProduct);
            this.Name = "AddProduct";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            this.grpFood.ResumeLayout(false);
            this.grpFood.PerformLayout();
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
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
        private Button btnAddProduct;
        private GroupBox grpBook;
        private TextBox txtISBN;
        private TextBox txtAuthor;
    }
}
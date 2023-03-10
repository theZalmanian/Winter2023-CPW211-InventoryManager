using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class AddProduct : Form
    {
        /// <summary>
        /// Represent's the different types of Products available
        /// </summary>
        public enum ProductTypes
        {
            Food, Book
        }

        /// <summary>
        /// Represent's the selected Product's type
        /// </summary>
        private ProductTypes _selectedType;

        public AddProduct(ProductTypes productType)
        {
            InitializeComponent();

            // Setup switch for all Product types
            switch (productType)
            {
                // If the product type is food
                case ProductTypes.Food:
                    // Display the food inputs
                    grpFood.Visible = true;

                    // Set the selected type as food
                    _selectedType = ProductTypes.Food;
                    break;

                // If the product type is book
                case ProductTypes.Book:
                    // Display the book inputs
                    grpBook.Visible = true;

                    // Set the selected type as book
                    _selectedType= ProductTypes.Book;
                    break;

                default:
                    break;
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            // Setup connection to db
            InheritanceContext dbContext = new();

            switch (_selectedType)
            {
                // If the product type is food
                case ProductTypes.Food:
                    // Create a food object using the given data
                    Food currFood = new()
                    {
                        StockKeepingUnit = txtSKU.Text,
                        Title = txtTitle.Text,
                        Price = Convert.ToDouble(txtPrice.Text),
                        Calories = Convert.ToInt32(txtCalories.Text),
                        Allergies = txtAllergies.Text
                    };

                    // Prepare the insert for the food item
                    dbContext.Products.Add(currFood);
                    break;

                // If the product type is book
                case ProductTypes.Book:
                    break;

                default:
                    break;
            }

            // Push all queries to the db
            dbContext.SaveChanges();
        }
    }
}

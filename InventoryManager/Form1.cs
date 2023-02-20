namespace InventoryManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the "Add Food" button is clicked, displays the "Add Product" 
        /// form with the food inputs visible
        /// </summary>
        private void BtnAddFood_Click(object sender, EventArgs e)
        {
            // Create new instance of "Add Product: Food" form
            AddProduct addProductForm = new(AddProduct.ProductTypes.Food);

            // Display it to the user
            addProductForm.ShowDialog();
        }

        /// <summary>
        /// When the "Add Book" button is clicked, displays the "Add Product" 
        /// form with the book inputs visible
        /// </summary>
        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            // Create new instance of "Add Product: Book" form
            AddProduct addProductForm = new(AddProduct.ProductTypes.Book);

            // Display it to the user
            addProductForm.ShowDialog();
        }
    }
}
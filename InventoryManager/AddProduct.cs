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
        public enum ProductTypes
        {
            Food, Book
        }

        public AddProduct(ProductTypes productType)
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}

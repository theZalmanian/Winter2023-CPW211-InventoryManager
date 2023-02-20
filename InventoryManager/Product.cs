using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    /// <summary>
    /// Represent's a product currently being sold
    /// </summary>
    public class Product
    {
        /// <summary>
        /// The product's stock keeping unit (Unique Identifier)
        /// </summary>
        [Key]
        public string StockKeepingUnit { get; set; }

        /// <summary>
        /// The product's name
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// The product's retail price
        /// </summary>
        [Required]
        public double Price { get; set; }
    }

    /// <summary>
    /// Represent's a food item currently being sold
    /// </summary>
    public class Food : Product
    {
        /// <summary>
        /// The food item's calorie count
        /// </summary>
        public int Calories { get; set; }

        /// <summary>
        /// A list of all allergy warnings
        /// </summary>
        public List<string> Allergies { get; set; }
    }

    /// <summary>
    /// Represent's a book currently being sold
    /// </summary>
    public class Book : Product
    {
        /// <summary>
        /// The book's International Standard Book Number
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// The full name of the book's author
        /// </summary>
        public string Author { get; set; }
    }
}

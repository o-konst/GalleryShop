// Author: Konstantin Ogai
// Date: 2025-06-22

namespace GalleryShop.Models
{
    /// <summary>
    /// Represents a product with title, description, price, and image.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the unique identifier for the order.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the product title.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the product description.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the product price.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the product image URL.
        /// </summary>
        public string Image { get; set; } = string.Empty;
    }
}
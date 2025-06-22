// Author: Konstantin Ogai
// Date: 2025-06-22

namespace GalleryShop.Models
{
    /// <summary>
    /// Represents a customer order, including its unique identifier, date, and status title.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets the unique identifier for the order.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the order was placed.
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or sets the status or title of the order.
        /// </summary>
        public string Title { get; set; } = string.Empty;
    }
}
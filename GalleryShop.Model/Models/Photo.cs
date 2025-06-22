// Author: Konstantin Ogai
// Date: 2025-06-22

using System.ComponentModel.DataAnnotations.Schema;

namespace GalleryShop.Models
{
    /// <summary>
    /// Represents a photo belonging to an album, including its metadata such as title, URL, and price.
    /// </summary>
    public class Photo
    {
        /// <summary>
        /// Gets or sets the unique identifier for the photo.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the album this photo belongs to.
        /// </summary>
        public int AlbumId { get; set; }

        /// <summary>
        /// Gets or sets the title or description of the photo.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the URL where the photo is stored.
        /// </summary>
        public string Url { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the price of the photo.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the price as a formatted string for display and editing.
        /// </summary>
        [NotMapped]
        public string PriceString
        {
            get => Price.ToString("F2");
            set
            {
                if (decimal.TryParse(value, out var parsedValue))
                {
                    Price = parsedValue;
                }
            }
        }
    }
}
// Author: Konstantin Ogai
// Date: 2025-06-22

namespace GalleryShop.Models
{
    /// <summary>
    /// Represents an album containing photos, with properties for title, image, and alias.
    /// </summary>
    public class Album
    {
        /// <summary>
        /// Gets or sets the unique identifier for the album.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title of the album.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the URL of the album's cover image.
        /// </summary>
        public string ImageUrl { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the alias or alternative name for the album.
        /// </summary>
        public string Alias { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the list of photos contained in the album.
        /// </summary>
        public List<Photo> Photos { get; set; } = [];
    }
}
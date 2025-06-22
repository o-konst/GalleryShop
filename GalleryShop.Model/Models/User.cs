// Author: Konstantin Ogai
// Date: 2025-06-22

namespace GalleryShop.Models
{
    /// <summary>
    /// Represents a user with personal and contact information.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the unique identifier for the user.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the full name of the user.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the username for the user.
        /// </summary>
        public string? Username { get; set; }

        /// <summary>
        /// Gets or sets the email address of the user.
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Gets or sets the phone number of the user.
        /// </summary>
        public string? Phone { get; set; }

        /// <summary>
        /// Gets or sets the website URL of the user.
        /// </summary>
        public string? Website { get; set; }
    }
}

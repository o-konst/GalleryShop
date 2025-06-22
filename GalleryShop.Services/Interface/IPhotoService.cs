// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Models;

namespace GalleryShop.Services
{
    /// <summary>
    /// Provides an interface for photo-related operations such as retrieving, creating, updating, and deleting photos.
    /// </summary>
    public interface IPhotoService
    {
        /// <summary>
        /// Retrieves a specific photo by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the photo.</param>
        /// <returns>The <see cref="Photo"/> if found; otherwise, null.</returns>
        Task<Photo?> GetPhoto(int id);

        /// <summary>
        /// Updates an existing photo.
        /// </summary>
        /// <param name="id">The unique identifier of the photo to update.</param>
        /// <param name="photo">The updated photo object.</param>
        /// <returns>The updated <see cref="Photo"/> if successful; otherwise, null.</returns>
        Task<Photo?> UpdatePhoto(int id, Photo photo);

        /// <summary>
        /// Deletes a photo by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the photo to delete.</param>
        /// <returns>True if the photo was deleted; otherwise, false or null.</returns>
        Task<bool?> DeletePhoto(int id);

        /// <summary>
        /// Creates a new photo.
        /// </summary>
        /// <param name="photo">The photo object to create.</param>
        /// <returns>The unique identifier of the newly created photo.</returns>
        Task<int> CreatePhoto(Photo photo);
    }
}

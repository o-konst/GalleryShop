// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Models;

namespace GalleryShop.Blazor_wasm
{
    /// <summary>
    /// Provides an interface for photo-related operations such as retrieving, updating, and deleting photos.
    /// </summary>
    public interface IPhotoService
    {
        /// <summary>
        /// Retrieves all albums asynchronously.
        /// </summary>
        /// <returns>A list of <see cref="Album"/> objects, or null if none found.</returns>
        Task<List<Album>?> GetAllAsync();

        /// <summary>
        /// Retrieves all photos for a specific album asynchronously.
        /// </summary>
        /// <param name="id">The unique identifier of the album.</param>
        /// <returns>A list of <see cref="Photo"/> objects, or null if none found.</returns>
        Task<List<Photo>?> GetAlbum(int id);

        /// <summary>
        /// Updates the specified photo asynchronously.
        /// </summary>
        /// <param name="photo">The photo object to update.</param>
        /// <returns>The updated <see cref="Photo"/> if successful; otherwise, null.</returns>
        Task<Photo?> UpdatePhoto(Photo photo);

        /// <summary>
        /// Deletes the specified photo asynchronously.
        /// </summary>
        /// <param name="photo">The photo object to delete.</param>
        /// <returns>True if the photo was deleted; otherwise, false.</returns>
        Task<bool> DeletePhoto(Photo photo);
    }
}
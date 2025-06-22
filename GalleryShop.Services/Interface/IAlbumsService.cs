// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Models;

namespace GalleryShop.Services
{
    /// <summary>
    /// Provides an interface for album-related operations such as retrieving, creating, updating, and deleting albums.
    /// </summary>
    public interface IAlbumsService
    {
        /// <summary>
        /// Retrieves a list of all albums.
        /// </summary>
        /// <returns>A list of <see cref="Album"/> objects.</returns>
        Task<List<Album>> GetAlbums();

        /// <summary>
        /// Retrieves a specific album by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the album.</param>
        /// <returns>The <see cref="Album"/> if found; otherwise, null.</returns>
        Task<Album?> GetAlbum(int id);

        /// <summary>
        /// Updates an existing album.
        /// </summary>
        /// <param name="id">The unique identifier of the album to update.</param>
        /// <param name="album">The updated album object.</param>
        /// <returns>The updated <see cref="Album"/> if successful; otherwise, null.</returns>
        Task<Album?> UpdateAlbum(int id, Album album);

        /// <summary>
        /// Deletes an album by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the album to delete.</param>
        /// <returns>True if the album was deleted; otherwise, false or null.</returns>
        Task<bool?> DeleteAlbum(int id);

        /// <summary>
        /// Creates a new album.
        /// </summary>
        /// <param name="album">The album object to create.</param>
        /// <returns>The unique identifier of the newly created album.</returns>
        Task<int> CreateAlbum(Album album);
    }
}

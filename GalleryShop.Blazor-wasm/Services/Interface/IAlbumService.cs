// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Models;

namespace GalleryShop.Blazor_wasm
{
    /// <summary>
    /// Provides an interface for album-related operations such as retrieving, creating, and getting albums.
    /// </summary>
    public interface IAlbumService
    {
        /// <summary>
        /// Retrieves all albums asynchronously.
        /// </summary>
        /// <returns>A list of <see cref="Album"/> objects, or null if none found.</returns>
        Task<List<Album>?> GetAllAsync();

        /// <summary>
        /// Retrieves a specific album by its unique identifier asynchronously.
        /// </summary>
        /// <param name="id">The unique identifier of the album.</param>
        /// <returns>The <see cref="Album"/> if found; otherwise, null.</returns>
        Task<Album?> GetAlbum(int id);

        /// <summary>
        /// Creates a new album asynchronously.
        /// </summary>
        /// <param name="album">The album object to create.</param>
        /// <returns>The created <see cref="Album"/>.</returns>
        Task<Album?> CreateAlbum(Album album);
    }
}
// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Models;

namespace GalleryShop.Blazor_wasm
{
    /// <summary>
    /// Provides an interface for user-related operations such as retrieving all users.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Retrieves all users asynchronously.
        /// </summary>
        /// <returns>A list of <see cref="User"/> objects, or null if none found.</returns>
        Task<List<User>?> GetAllAsync();
    }
}

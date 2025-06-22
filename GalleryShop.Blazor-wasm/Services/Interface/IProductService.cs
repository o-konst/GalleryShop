// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Models;

namespace GalleryShop.Blazor_wasm
{
    /// <summary>
    /// Provides an interface for product-related operations such as retrieving all products.
    /// </summary>
    public interface IProductService
    {
        /// <summary>
        /// Retrieves all products asynchronously.
        /// </summary>
        /// <returns>A list of <see cref="Product"/> objects, or null if none found.</returns>
        Task<List<Product>?> GetAllAsync();
    }
}
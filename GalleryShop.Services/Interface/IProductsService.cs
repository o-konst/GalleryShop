// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Models;

namespace GalleryShop.Services
{
    /// <summary>
    /// Provides an interface for product-related operations such as retrieving all products.
    /// </summary>
    public interface IProductsService
    {
        /// <summary>
        /// Retrieves a list of all products.
        /// </summary>
        /// <returns>A list of <see cref="Product"/> objects.</returns>
        Task<List<Product>> GetProducts();
    }
}

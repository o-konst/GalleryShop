// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Models;

namespace GalleryShop.Blazor_wasm
{
    /// <summary>
    /// Provides an interface for order-related operations such as retrieving all orders or a specific order.
    /// </summary>
    public interface IOrderService
    {
        /// <summary>
        /// Retrieves all orders from the backend API.
        /// </summary>
        /// <returns>A list of <see cref="Order"/> objects, or null if the request fails.</returns>
        Task<List<Order>?> GetAllAsync();

        /// <summary>
        /// Retrieves a specific order by its unique identifier from the backend API.
        /// </summary>
        /// <param name="id">The unique identifier of the order.</param>
        /// <returns>The <see cref="Order"/> if found; otherwise, null.</returns>
        Task<Order?> GetOrder(int id);
    }
}
// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Models;

namespace GalleryShop.Services
{
    /// <summary>
    /// Provides an interface for order-related operations such as retrieving all orders or a specific order.
    /// </summary>
    public interface IOrdersService
    {
        /// <summary>
        /// Retrieves a list of all orders.
        /// </summary>
        /// <returns>A list of <see cref="Order"/> objects.</returns>
        Task<List<Order>> GetOrders();

        /// <summary>
        /// Retrieves a specific order by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the order.</param>
        /// <returns>The <see cref="Order"/> if found; otherwise, null.</returns>
        Task<Order?> GetOrder(int id);
    }
}

// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Data;
using GalleryShop.Models;
using Microsoft.EntityFrameworkCore;

namespace GalleryShop.Services
{
    /// <summary>
    /// Service for order-related operations such as retrieving all orders or a specific order.
    /// </summary>
    public class OrdersService(AppDbContext context) : BaseService(context), IOrdersService
    {
        /// <summary>
        /// Retrieves a specific order by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the order.</param>
        /// <returns>The <see cref="Order"/> if found; otherwise, null.</returns>
        public async Task<Order?> GetOrder(int id)
        {
            var order = await _context.Orders
             .Where(o => o.Id == id)
             .Select(o => new Order
             {
                 Id = o.Id,
                 Title = o.Title
             })
             .FirstOrDefaultAsync();

            return order;
        }

        /// <summary>
        /// Retrieves a list of all orders.
        /// </summary>
        /// <returns>A list of <see cref="Order"/> objects.</returns>
        public async Task<List<Order>> GetOrders()
        {
            var result = await _context.Orders.Select(x => new Order
            {
                Id = x.Id,
                Title = x.Title
            }).ToListAsync();

            return result;
        }
    }
}

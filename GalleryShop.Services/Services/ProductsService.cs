// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Data;
using GalleryShop.Models;
using Microsoft.EntityFrameworkCore;

namespace GalleryShop.Services
{
    /// <summary>
    /// Service for product-related operations such as retrieving all products.
    /// </summary>
    public class ProductsService(AppDbContext context) : BaseService(context), IProductsService
    {
        /// <summary>
        /// Retrieves a list of all products.
        /// </summary>
        /// <returns>A list of <see cref="Product"/> objects.</returns>
        public async Task<List<Product>> GetProducts()
        {
            var result = await _context.Products.Select(x => new Product
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                Price = x.Price,
                Image = x.Image
            }).ToListAsync();

            return result;
        }
    }
}

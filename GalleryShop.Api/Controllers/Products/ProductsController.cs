// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Services;
using Microsoft.AspNetCore.Mvc;

namespace GalleryShop.Api.Controllers
{
    /// <summary>
    /// Controller for managing product collections.
    /// Provides an endpoint to retrieve all products.
    /// </summary>
    [ApiController]
    [Route("api/products")]
    public class ProductsControllerr(IProductsService productsService) : ControllerBase
    {
        private readonly IProductsService _productsService = productsService;

        /// <summary>
        /// Retrieves all products.
        /// </summary>
        /// <returns>A list of all products.</returns>
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var result = await _productsService.GetProducts();
            return Ok(result);
        }
    }
}
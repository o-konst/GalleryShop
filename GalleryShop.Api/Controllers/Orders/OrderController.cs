// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Services;
using Microsoft.AspNetCore.Mvc;

namespace GalleryShop.Api.Controllers
{
    /// <summary>
    /// Controller for managing order resources.
    /// Provides endpoints for retrieving orders.
    /// </summary>
    [ApiController]
    [Route("api/order")]
    public class OrderController(IOrdersService ordersService) : ControllerBase
    {
        private readonly IOrdersService _ordersService = ordersService;

        /// <summary>
        /// Retrieves an order by its unique identifier.
        /// </summary>
        /// <param name="id">The order's unique identifier.</param>
        /// <returns>The order if found; otherwise, NotFound.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder(int id)
        {
            var result = await _ordersService.GetOrder(id);
            return Ok(result);
        }
    }
}
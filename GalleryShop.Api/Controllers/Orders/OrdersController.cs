// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Services;
using Microsoft.AspNetCore.Mvc;

namespace GalleryShop.Api.Controllers
{
    /// <summary>
    /// Controller for managing order collections.
    /// Provides an endpoint to retrieve all orders.
    /// </summary>
    [ApiController]
    [Route("api/orders")]
    public class OrdersController(IOrdersService ordersService) : ControllerBase
    {
        private readonly IOrdersService _ordersService = ordersService;

        /// <summary>
        /// Retrieves all orders.
        /// </summary>
        /// <returns>A list of all orders.</returns>
        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var result = await _ordersService.GetOrders();
            return Ok(result);
        }
    }
}
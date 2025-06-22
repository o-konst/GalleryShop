// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Models;
using System.Net.Http.Json;

namespace GalleryShop.Blazor_wasm
{
    /// <summary>
    /// Provides order-related data operations for the Blazor WebAssembly application.
    /// Handles HTTP requests to retrieve order information from the backend API.
    /// </summary>
    public class OrderService(HttpClient httpClient) : IOrderService
    {
        private readonly HttpClient _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));

        /// <summary>
        /// Retrieves all orders asynchronously from the backend API.
        /// </summary>
        /// <returns>A list of <see cref="Order"/> objects, or null if the request fails.</returns>
        public async Task<List<Order>?> GetAllAsync()
        {
           return await _httpClient.GetFromJsonAsync<List<Order>>("orders");
        }

        /// <summary>
        /// Retrieves a specific order by its unique identifier asynchronously from the backend API.
        /// </summary>
        /// <param name="id">The unique identifier of the order.</param>
        /// <returns>The <see cref="Order"/> if found; otherwise, null.</returns>
        public async Task<Order?> GetOrder(int id)
        {
            return await _httpClient.GetFromJsonAsync<Order>($"order/{id}");
        }
    }
}
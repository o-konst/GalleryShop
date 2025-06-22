// Author: Konstantin Ogai
// Date: 2025-06-21

using GalleryShop.Models;
using System.Net.Http.Json;

namespace GalleryShop.Blazor_wasm
{
    /// <summary>
    /// Provides order-related data operations for the Blazor WebAssembly application.
    /// Handles HTTP requests to retrieve order information from the backend API.
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        /// <inheritdoc/>
        public async Task<List<Product>?> GetAllAsync()
        {
            var products = await _httpClient.GetFromJsonAsync<List<Product>>("products");
            return products;
        }
    }
}
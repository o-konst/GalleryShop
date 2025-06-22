// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Models;
using System.Net.Http.Json;

namespace GalleryShop.Blazor_wasm
{
    /// <summary>
    /// Provides user-related data operations for the Blazor WebAssembly application.
    /// Handles HTTP requests to retrieve user information from the backend API.
    /// </summary>
    public class UserService(HttpClient httpClient) : IUserService
    {
        private readonly HttpClient _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));

        /// <summary>
        /// Retrieves all users asynchronously from the backend API.
        /// </summary>
        /// <returns>A list of <see cref="User"/> objects, or null if none found.</returns>
        public async Task<List<User>?> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<User>>("users");
        }
    }
}

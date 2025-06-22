// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Models;
using System.Net.Http.Json;

namespace GalleryShop.Blazor_wasm
{
    /// <summary>
    /// Provides album-related data operations for the Blazor WebAssembly application.
    /// Handles HTTP requests to retrieve and manage album information from the backend API.
    /// </summary>
    public class AlbumService(HttpClient httpClient) : IAlbumService
    {
        private readonly HttpClient _httpClient = httpClient;

        /// <summary>
        /// Retrieves all albums asynchronously from the backend API.
        /// </summary>
        /// <returns>A list of <see cref="Album"/> objects, or null if none found.</returns>
        public async Task<List<Album>?> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Album>>("albums");
        }

        /// <summary>
        /// Retrieves a specific album by its unique identifier asynchronously from the backend API.
        /// </summary>
        /// <param name="id">The unique identifier of the album.</param>
        /// <returns>The <see cref="Album"/> if found; otherwise, null.</returns>
        public async Task<Album?> GetAlbum(int id)
        {
            return await _httpClient.GetFromJsonAsync<Album>($"album/{id}");
        }

        /// <summary>
        /// Creates a new album asynchronously by sending a POST request to the backend API.
        /// </summary>
        /// <param name="album">The album object to create.</param>
        /// <returns>The created <see cref="Album"/> if successful; otherwise, null.</returns>
        public async Task<Album?> CreateAlbum(Album album)
        {
            var response = await _httpClient.PostAsJsonAsync<Album>($"album", album);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<Album>();
                return result;
            }

            return null;
        }
    }
}
// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Models;
using System.Net.Http.Json;

namespace GalleryShop.Blazor_wasm
{
    /// <summary>
    /// Provides photo-related data operations for the Blazor WebAssembly application.
    /// Handles HTTP requests to retrieve, update, and delete photo information from the backend API.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="PhotoService"/> class.
    /// </remarks>
    /// <param name="httpClient">The HTTP client used to send requests to the backend API.</param>
    public class PhotoService(HttpClient httpClient) : IPhotoService
    {
        private readonly HttpClient _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));

        /// <summary>
        /// Retrieves all albums asynchronously from the backend API.
        /// </summary>
        /// <returns>A list of <see cref="Album"/> objects, or null if none found.</returns>
        public async Task<List<Album>?> GetAllAsync()
        {
            var orders = await _httpClient.GetFromJsonAsync<List<Album>>("albums");
            return orders;
        }

        /// <summary>
        /// Retrieves all photos for a specific album asynchronously from the backend API.
        /// </summary>
        /// <param name="id">The unique identifier of the album.</param>
        /// <returns>A list of <see cref="Photo"/> objects, or null if none found.</returns>
        public async Task<List<Photo>?> GetAlbum(int id)
        {
            var photos = await _httpClient.GetFromJsonAsync<List<Photo>>($"photos?albumId={id}");
            return photos;
        }

        /// <summary>
        /// Updates the specified photo asynchronously by sending a PUT request to the backend API.
        /// </summary>
        /// <param name="photo">The photo object to update.</param>
        /// <returns>The updated <see cref="Photo"/> if successful; otherwise, null.</returns>
        public async Task<Photo?> UpdatePhoto(Photo photo)
        {
            var response = await _httpClient.PutAsJsonAsync($"album/{photo.AlbumId}/photo/{photo.Id}", photo);

            if (response.IsSuccessStatusCode)
            {
                var updatedPhoto = await response.Content.ReadFromJsonAsync<Photo>();
                return updatedPhoto;
            }

            return null;
        }

        /// <summary>
        /// Deletes the specified photo asynchronously by sending a DELETE request to the backend API.
        /// </summary>
        /// <param name="photo">The photo object to delete.</param>
        /// <returns>True if the photo was deleted; otherwise, false.</returns>
        public async Task<bool> DeletePhoto(Photo photo)
        {
            var response = await _httpClient.DeleteAsync($"album/{photo.AlbumId}/photo/{photo.Id}");

            if (response.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }
    }
}
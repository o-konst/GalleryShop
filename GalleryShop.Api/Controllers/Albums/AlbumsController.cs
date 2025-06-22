// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Services;
using Microsoft.AspNetCore.Mvc;

namespace GalleryShop.Api.Controllers
{
    /// <summary>
    /// Controller for managing album collections.
    /// Provides an endpoint to retrieve all albums.
    /// </summary>
    [ApiController]
    [Route("api/albums")]
    public class AlbumsController(IAlbumsService albumsService) : ControllerBase
    {
        private readonly IAlbumsService _albumsService = albumsService;

        /// <summary>
        /// Retrieves all albums.
        /// </summary>
        /// <returns>A list of all albums.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAlbums()
        {
            var result = await _albumsService.GetAlbums();
            return Ok(result);
        }
    }
}
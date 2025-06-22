// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Models;
using GalleryShop.Services;
using Microsoft.AspNetCore.Mvc;

namespace GalleryShop.Api.Controllers
{
    /// <summary>
    /// Controller for managing album resources.
    /// Provides endpoints for retrieving, creating, updating, and deleting albums.
    /// </summary>
    [ApiController]
    [Route("api/album")]
    public class AlbumController(IAlbumsService albumsService) : ControllerBase
    {
        private readonly IAlbumsService _albumsService = albumsService;

        /// <summary>
        /// Retrieves an album by its unique identifier.
        /// </summary>
        /// <param name="id">The album's unique identifier.</param>
        /// <returns>The album if found; otherwise, NotFound.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAlbum(int id)
        {
            var album = await _albumsService.GetAlbum(id);

            if (album == null)
                return NotFound();

            return Ok(album);
        }

        /// <summary>
        /// Updates an existing album.
        /// </summary>
        /// <param name="id">The album's unique identifier.</param>
        /// <param name="album">The updated album object.</param>
        /// <returns>The updated album if successful; otherwise, NotFound or BadRequest.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAlbum(int id, [FromBody] Album album)
        {
            if (id != album.Id)
                return BadRequest();

            var result = await _albumsService.UpdateAlbum(id, album);
            if (result == null)
                return NotFound();

            return Ok(result);
        }

        /// <summary>
        /// Deletes an album by its unique identifier.
        /// </summary>
        /// <param name="id">The album's unique identifier.</param>
        /// <returns>NoContent if deleted; otherwise, NotFound.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlbum(int id)
        {
            var album = await _albumsService.DeleteAlbum(id);
            if (album == null)
                return NotFound();

            return NoContent();
        }

        /// <summary>
        /// Creates a new album.
        /// </summary>
        /// <param name="album">The album object to create.</param>
        /// <returns>The created album with its new identifier.</returns>
        [HttpPost]
        public async Task<IActionResult> CreateAlbum([FromBody] Album album)
        {
            var albumId = await _albumsService.CreateAlbum(album);
            return CreatedAtAction(nameof(GetAlbum), new { id = albumId }, album);
        }
    }
}
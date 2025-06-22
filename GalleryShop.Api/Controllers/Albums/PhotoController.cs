// Author: Konstantin Ogai
// Date: 2025-06-22

using Amazon.S3;
using Amazon.S3.Transfer;
using GalleryShop.Models;
using GalleryShop.Services;
using Microsoft.AspNetCore.Mvc;

namespace GalleryShop.Api.Controllers
{
    /// <summary>
    /// Controller for managing photo resources within albums.
    /// Provides endpoints for retrieving, updating, deleting, and uploading photos.
    /// </summary>
    [ApiController]
    [Route("api/album/{albumId}/photo")]
    public class PhotoController(IPhotoService photoService, IAmazonS3 s3Client) : ControllerBase
    {
        private readonly IPhotoService _photoService = photoService;
        private readonly IAmazonS3 _s3Client = s3Client;
        private readonly static string BucketName = "blazor-w";

        /// <summary>
        /// Retrieves a photo by its unique identifier.
        /// </summary>
        /// <param name="id">The photo's unique identifier.</param>
        /// <returns>The photo if found; otherwise, NotFound.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPhoto(int id)
        {
            var photo = await _photoService.GetPhoto(id);

            if (photo == null)
                return NotFound();

            return Ok(photo);
        }

        /// <summary>
        /// Updates an existing photo.
        /// </summary>
        /// <param name="id">The photo's unique identifier.</param>
        /// <param name="photo">The updated photo object.</param>
        /// <returns>The updated photo if successful; otherwise, NotFound or BadRequest.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePhoto(int id, [FromBody] Photo photo)
        {
            if (id != photo.Id)
                return BadRequest();

            var result = await _photoService.UpdatePhoto(id, photo);
            if (result == null)
                return NotFound();

            return Ok(result);
        }

        /// <summary>
        /// Deletes a photo by its unique identifier.
        /// </summary>
        /// <param name="id">The photo's unique identifier.</param>
        /// <returns>NoContent if deleted; otherwise, NotFound.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePhoto(int id)
        {
            var album = await _photoService.DeletePhoto(id);
            if (album == null)
                return NotFound();

            return NoContent();
        }

        /// <summary>
        /// Uploads a new photo to the specified album and stores it in S3.
        /// </summary>
        /// <param name="albumId">The album's unique identifier.</param>
        /// <param name="file">The photo file to upload.</param>
        /// <returns>The URL of the uploaded photo.</returns>
        [HttpPost]
        public async Task<IActionResult> Upload([FromRoute] int albumId, [FromForm] IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("No file uploaded.");

            var uploadRequest = new TransferUtilityUploadRequest
            {
                InputStream = file.OpenReadStream(),
                Key = $"media/{albumId}/{file.FileName}",
                BucketName = BucketName,
                ContentType = file.ContentType
            };

            var transferUtility = new TransferUtility(_s3Client);
            await transferUtility.UploadAsync(uploadRequest);

            var url = $"https://{BucketName}.s3.amazonaws.com/media/{albumId}/{file.FileName}";

            if (albumId > 0)
            {
                await _photoService.CreatePhoto(new Photo
                {
                    AlbumId = albumId,
                    Url = url
                });
            }

            return Ok(new { url });
        }
    }
}
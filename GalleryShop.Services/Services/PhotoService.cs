// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Data;
using GalleryShop.Models;

namespace GalleryShop.Services
{
    /// <summary>
    /// Service for photo-related operations such as retrieving, creating, updating, and deleting photos.
    /// </summary>
    public class PhotoService(AppDbContext context) : BaseService(context), IPhotoService
    {
        /// <summary>
        /// Retrieves a specific photo by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the photo.</param>
        /// <returns>The <see cref="Photo"/> if found; otherwise, null.</returns>
        public async Task<Photo?> GetPhoto(int id)
        {
            var photo = await _context.Photos.FindAsync(id);
            return photo;
        }

        /// <summary>
        /// Updates an existing photo.
        /// </summary>
        /// <param name="id">The unique identifier of the photo to update.</param>
        /// <param name="photo">The updated photo object.</param>
        /// <returns>The updated <see cref="Photo"/> if successful; otherwise, null.</returns>
        public async Task<Photo?> UpdatePhoto(int id, Photo photo)
        {
            var existing = await _context.Photos.FindAsync(id);
            if (existing == null)
                return null;

            existing.Title = photo.Title;
            existing.Price = photo.Price;

            await _context.SaveChangesAsync();
            return existing;
        }

        /// <summary>
        /// Deletes a photo by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the photo to delete.</param>
        /// <returns>True if the photo was deleted; otherwise, false or null.</returns>
        public async Task<bool?> DeletePhoto(int id)
        {
            var photo = await _context.Photos.FindAsync(id);
            if (photo == null)
                return null;

            _context.Photos.Remove(photo);
            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Creates a new photo.
        /// </summary>
        /// <param name="photo">The photo object to create.</param>
        /// <returns>The unique identifier of the newly created photo.</returns>
        public async Task<int> CreatePhoto(Photo photo)
        {
            _context.Photos.Add(photo);
            var id = await _context.SaveChangesAsync();
            return id;
        }
    }
}

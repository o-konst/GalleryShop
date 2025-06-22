// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Data;
using GalleryShop.Models;
using Microsoft.EntityFrameworkCore;

namespace GalleryShop.Services
{
    /// <summary>
    /// Service for album-related operations such as retrieving, creating, updating, and deleting albums.
    /// </summary>
    public class AlbumsService(AppDbContext context) : BaseService(context), IAlbumsService
    {
        /// <summary>
        /// Retrieves a list of all albums.
        /// </summary>
        /// <returns>A list of <see cref="Album"/> objects.</returns>
        public async Task<List<Album>> GetAlbums()
        {
            var result = await _context.Albums.Select(x => new Album
            {
                Id = x.Id,
                Title = x.Title,
                ImageUrl = x.ImageUrl,
                Alias = x.Alias
            }).ToListAsync();

            return result;
        }

        /// <summary>
        /// Retrieves a specific album by its unique identifier, including its photos.
        /// </summary>
        /// <param name="id">The unique identifier of the album.</param>
        /// <returns>The <see cref="Album"/> if found; otherwise, null.</returns>
        public async Task<Album?> GetAlbum(int id)
        {
            var album = await _context.Albums
             .Where(a => a.Id == id)
             .Select(a => new Album
             {
                 Id = a.Id,
                 Title = a.Title,
                 ImageUrl =  a.ImageUrl,
                 Alias = a.Alias,
                 Photos =_context.Set<Photo>().Where(p => p.AlbumId == a.Id).ToList()
             })
             .FirstOrDefaultAsync();

            return album;
        }

        /// <summary>
        /// Updates an existing album.
        /// </summary>
        /// <param name="id">The unique identifier of the album to update.</param>
        /// <param name="album">The updated album object.</param>
        /// <returns>The updated <see cref="Album"/> if successful; otherwise, null.</returns>
        public async Task<Album?> UpdateAlbum(int id, Album album)
        {
            var existing = await _context.Albums.FindAsync(id);
            if (existing == null)
                return null;

            existing.Title = album.Title;
            existing.ImageUrl = album.ImageUrl;
            existing.Alias = album.Alias;

            await _context.SaveChangesAsync();
            return existing;
        }

        /// <summary>
        /// Deletes an album by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the album to delete.</param>
        /// <returns>True if the album was deleted; otherwise, false or null.</returns>
        public async Task<bool?> DeleteAlbum(int id)
        {
            var album = await _context.Albums.FindAsync(id);
            if (album == null)
                return null;

            _context.Albums.Remove(album);
            await _context.SaveChangesAsync();
            return  true;
        }

        /// <summary>
        /// Creates a new album.
        /// </summary>
        /// <param name="album">The album object to create.</param>
        /// <returns>The unique identifier of the newly created album.</returns>
        public async Task<int> CreateAlbum(Album album)
        {
            _context.Albums.Add(album);
            var id = await _context.SaveChangesAsync();
            return id;
        }
    }
}

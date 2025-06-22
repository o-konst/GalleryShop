// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Models;
using Microsoft.EntityFrameworkCore;

namespace GalleryShop.Data
{
    /// <summary>
    /// Represents the Entity Framework database context for the GalleryShop application.
    /// Provides access to Albums, Products, Photos, and Orders tables.
    /// </summary>
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        /// <summary>
        /// Gets or sets the Albums table.
        /// </summary>
        public DbSet<Album> Albums { get; set; }

        /// <summary>
        /// Gets or sets the Products table.
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Gets or sets the Photos table.
        /// </summary>
        public DbSet<Photo> Photos { get; set; }

        /// <summary>
        /// Gets or sets the Orders table.
        /// </summary>
        public DbSet<Order> Orders { get; set; }
    }
}


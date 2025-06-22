// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Provides extension methods for configuring services related to the database.
/// </summary>
public static class Extensions
{
    /// <summary>
    /// Adds and configures the AppDbContext with a PostgreSQL connection to the service collection.
    /// </summary>
    /// <param name="services">The service collection to add the DbContext to.</param>
    /// <param name="baseAddress">The PostgreSQL connection string.</param>
    public static void AddDB(this IServiceCollection services, string baseAddress)
    {
        services.AddDbContext<AppDbContext>(options => { 
            options.UseNpgsql(baseAddress);
        });
    }
}

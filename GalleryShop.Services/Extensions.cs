// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Services;
using Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Provides extension methods for registering application services in the dependency injection container.
/// </summary>
public static class Extensions
{
    /// <summary>
    /// Registers all application services with the dependency injection container.
    /// </summary>
    /// <param name="services">The service collection to add the services to.</param>
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IAlbumsService, AlbumsService>();
        services.AddScoped<IPhotoService, PhotoService>();
        services.AddScoped<IProductsService, ProductsService>();
        services.AddScoped<IOrdersService, OrdersService>();
    }
}

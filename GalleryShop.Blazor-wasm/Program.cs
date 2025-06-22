
using GalleryShop.Blazor_wasm;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.FluentUI.AspNetCore.Components;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Read API base address from configuration
var apiBaseAddress = builder.Configuration["ApiBaseAddress"] ?? builder.HostEnvironment.BaseAddress;

builder.Services.AddHttpClient<IUserService, UserService>(client =>
{
    client.BaseAddress = new Uri(apiBaseAddress);
});

builder.Services.AddHttpClient<IOrderService, OrderService>(client =>
{
    client.BaseAddress = new Uri(apiBaseAddress);
});

builder.Services.AddHttpClient<IPhotoService, PhotoService>(client =>
{
    client.BaseAddress = new Uri(apiBaseAddress);
});

builder.Services.AddHttpClient<IProductService, ProductService>(client =>
{
    client.BaseAddress = new Uri(apiBaseAddress);
});

builder.Services.AddHttpClient<IAlbumService, AlbumService>(client =>
{
    client.BaseAddress = new Uri(apiBaseAddress);
});

builder.Services.AddFluentUIComponents();

await builder.Build().RunAsync();

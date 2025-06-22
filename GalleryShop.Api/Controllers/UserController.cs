// Author: Konstantin Ogai
// Date: 2025-06-22

using Microsoft.AspNetCore.Mvc;
using GalleryShop.Data;

namespace GalleryShop.Api.Controllers
{
    /// <summary>
    /// Controller for managing user resources.
    /// Provides endpoints for user-related operations.
    /// </summary>
    [ApiController]
    [Route("api/user")]
    public class UserController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;
    }
}

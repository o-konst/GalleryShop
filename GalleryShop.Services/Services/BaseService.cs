// Author: Konstantin Ogai
// Date: 2025-06-22

using GalleryShop.Data;

namespace GalleryShop.Services
{
    public class BaseService(AppDbContext context)
    {
        protected readonly AppDbContext _context = context;
    }
}

using Microsoft.EntityFrameworkCore;

namespace HotelAPI.DA
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
    }
}
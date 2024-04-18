using Microsoft.EntityFrameworkCore;

namespace Store_MVC.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {
        }
    }
}

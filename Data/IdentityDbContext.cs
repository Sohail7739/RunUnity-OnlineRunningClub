using Microsoft.EntityFrameworkCore;

namespace Rungroopwebapp.Data
{
    public class IdentityDbContext<T>
    {
        private DbContextOptions<ApplicationDbContext> options;

        public IdentityDbContext(DbContextOptions<ApplicationDbContext> options)
        {
            this.options = options;
        }
    }
}
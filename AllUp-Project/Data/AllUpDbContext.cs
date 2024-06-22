using AllUp_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace AllUp_Project.Data
{
    public class AllUpDbContext : DbContext
    {
        public DbSet<Setting> Settings { get; set; }
        public AllUpDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace dotnetdocker.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
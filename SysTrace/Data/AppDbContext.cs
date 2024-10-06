using Microsoft.EntityFrameworkCore;
using SysTrace.models.Platform;

namespace SysTrace.Data {

    public class AppDbContext : DbContext {
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
       

        public DbSet<Platform> platforms {get; set;}
    }
}
using Microsoft.EntityFrameworkCore;


public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {}
        public DbSet<UserEntity> Users { get; set; }
    }

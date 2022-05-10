using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class GymmrDbContext : DbContext
    {
        public GymmrDbContext(DbContextOptions<GymmrDbContext> options)
            : base(options)
        {
        }

        public DbSet<PostEntity> Posts => Set<PostEntity>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            optionsBuilder
                .UseSqlite($"Data Source={Path.Join(path, "gymmr.db")}");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            SeedData.Seed(builder);
        }
    }
}
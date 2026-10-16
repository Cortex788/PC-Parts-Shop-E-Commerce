using Microsoft.EntityFrameworkCore;

namespace PC_Parts_Shop_E_Commerce.Data
{
    using Models;
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Brand> Brands { get; set; } = null!;
        public virtual DbSet<GPU> GPUs { get; set; } = null!;
        public virtual DbSet<CPU> CPUs { get; set; } = null!;
        public virtual DbSet<RAM> RAMs { get; set; } = null!;

        public virtual DbSet<Motherboard> Motherboards { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}

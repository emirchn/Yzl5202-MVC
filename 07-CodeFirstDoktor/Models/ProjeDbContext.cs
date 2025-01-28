using Microsoft.EntityFrameworkCore;

namespace _07_CodeFirstDoktor.Models
{
    public class ProjeDbContext : DbContext
    {
        public ProjeDbContext(DbContextOptions<ProjeDbContext> options) : base(options)
        {
        }

        public DbSet<Doktor> Doktorlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-UKJPG3A; Database=Yzl5202-CodeFirst3;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doktor>().Property(x => x.Ad).HasMaxLength(15).IsRequired();
            modelBuilder.Entity<Doktor>().Property(x => x.Soyad).IsRequired().HasMaxLength(20);
            base.OnModelCreating(modelBuilder);
        }
    }
}
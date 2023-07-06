using ComplexManagment.Entities;
using Microsoft.EntityFrameworkCore;

namespace ComplexManagment
{
    public class ComplexContext : DbContext
    {
        public ComplexContext(DbContextOptions<ComplexContext>options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ComplexContext).Assembly);
        }

        public DbSet<Complex> Complexs { get; set; }
        public DbSet<Blook> Blooks { get; set; }
        public DbSet<Unit> Units { get; set; }

    }
}

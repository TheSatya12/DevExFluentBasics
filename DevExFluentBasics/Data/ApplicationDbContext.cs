using DevExFluentBasics.Models;
using Microsoft.EntityFrameworkCore;

namespace DevExFluentBasics.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<AnnualBudget> AnnualBudget { get; set; }
        public DbSet<Department> Department { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Budget)
                    .HasPrecision(18, 2);

                entity.Property(e => e.Expense)
                    .HasPrecision(18, 2);
            });
        }
    }
}

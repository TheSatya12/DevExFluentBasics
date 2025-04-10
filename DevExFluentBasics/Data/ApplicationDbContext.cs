using DevExFluentBasics.Models;
using Microsoft.EntityFrameworkCore;

namespace DevExFluentBasics.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<AnnualBudget> AnnualBudgets { get; set; }
        public DbSet<Department> Departments { get; set; }

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

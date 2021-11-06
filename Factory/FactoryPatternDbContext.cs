using Microsoft.EntityFrameworkCore;

namespace Factory
{
    public class FactoryPatternDbContext:DbContext
    {
 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("FactoryDb");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;

namespace FactoryMethod
{
    public class FactoryMethodDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("FactoryMethod");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
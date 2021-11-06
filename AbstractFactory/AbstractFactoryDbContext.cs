using Microsoft.EntityFrameworkCore;

namespace AbstractFactory
{
    public class AbstractFactoryDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("FactoryMethod");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
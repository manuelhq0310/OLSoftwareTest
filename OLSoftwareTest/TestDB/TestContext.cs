using Microsoft.EntityFrameworkCore;
using TestDB.Models;

namespace TestDB
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

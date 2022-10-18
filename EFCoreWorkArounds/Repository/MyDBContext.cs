using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class MyDBContext : DbContext
    {
        private readonly string _connectionString;

        public MyDBContext(string connectionString)
        {
            _connectionString = connectionString;
            Database.EnsureCreated(); // Calling Ensure created In the constructor, checks everytime you create the object.
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_connectionString != null)
                optionsBuilder.UseSqlServer(_connectionString);
            else
                base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
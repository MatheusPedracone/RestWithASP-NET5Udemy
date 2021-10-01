using Microsoft.EntityFrameworkCore;

namespace RestWithASPNETUdemy.models.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}
        public DbSet<Person> Persons { get; set; }
    }
}
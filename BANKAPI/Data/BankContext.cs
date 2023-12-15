using BANKAPI.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace BANKAPI.Data
{
    public class BankContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "Bankdb");
        }

        public DbSet<User> Users { get; set; }
    }
}

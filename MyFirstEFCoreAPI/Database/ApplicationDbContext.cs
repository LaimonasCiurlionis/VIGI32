using Microsoft.EntityFrameworkCore;
using MyFirstEFCoreAPI.Database.Entities;

namespace MyFirstEFCoreAPI.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}

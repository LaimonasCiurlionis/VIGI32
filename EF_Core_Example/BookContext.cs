using Microsoft.EntityFrameworkCore;

namespace EF_Core_Example
{
    public class BookContext : DbContext
    {
        public DbSet<Page> Pages { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Folder> Folders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) 
        {
            options.UseSqlServer("Data Source=.;Initial Catalog=EF_Core_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}

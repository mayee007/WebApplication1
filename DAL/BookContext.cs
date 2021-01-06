using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class BookContext : DbContext
    {
        public BookContext()
        {
        }
        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
        }

        //public DbSet<Book> Books { get; set; }

        //public DbSet<Author> Authors { get; set; }

        public DbSet<Name> Names { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Name>().HasKey(x => x.Id);
            builder.Entity<Name>().ToTable("dbo.Name");

            base.OnModelCreating(builder);
        }                
    }
}


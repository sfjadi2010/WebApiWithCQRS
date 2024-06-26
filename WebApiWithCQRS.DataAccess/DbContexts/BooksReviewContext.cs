using Microsoft.EntityFrameworkCore;
using WebApiWithCQRS.DataAccess.Models;

namespace WebApiWithCQRS.DataAccess.DbContexts;

public class BooksReviewContext : DbContext
{
    public BooksReviewContext(DbContextOptions<BooksReviewContext> options) : base(options) { }

    public DbSet<Book> Books { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().HasKey(b => b.Id);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.; Initial Catalog=BookReviewDb; Integrated Security=true; TrustServerCertificate=true;");
    }
}

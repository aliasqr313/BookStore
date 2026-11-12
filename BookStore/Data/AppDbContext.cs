using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().HasData(
            new Book { Id = 1, Title = "من به شما نشان خواهم داد که چگونه بود", Author = "Illia Ponomarenko", Price = 15000, ImageFileName = "9780143137894.webp", Description = "داستان کیف در زمان جنگ" },
            new Book { Id = 2, Title = "کتاب نمونه دوم", Author = "نویسنده دوم", Price = 22000, ImageFileName = "9780063317475.webp", Description = "توضیح کوتاه کتاب" },
            new Book { Id = 3, Title = "کتاب نمونه سوم", Author = "نویسنده سوم", Price = 18000, ImageFileName = "9781620401620.jpg", Description = "توضیح کوتاه کتاب" }
        );
    }
}
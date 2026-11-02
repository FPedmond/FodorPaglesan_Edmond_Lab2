using Microsoft.EntityFrameworkCore;
using FodorPaglesan_Edmond_Lab2.Models;

public class FodorPaglesan_Edmond_Lab2Context(DbContextOptions<FodorPaglesan_Edmond_Lab2Context> options) : DbContext(options)
{
    public DbSet<FodorPaglesan_Edmond_Lab2.Models.Book> Book { get; set; } = default!;

public DbSet<FodorPaglesan_Edmond_Lab2.Models.Publisher> Publisher { get; set; } = default!;
}

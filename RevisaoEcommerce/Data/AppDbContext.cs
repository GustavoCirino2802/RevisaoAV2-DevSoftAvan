using Microsoft.EntityFrameworkCore;
using RevisaoEcommerce.Models;

namespace RevisaoEcommerce.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Produto> Produtos { get; set; }
}

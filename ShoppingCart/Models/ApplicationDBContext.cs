using Microsoft.EntityFrameworkCore;

namespace ShoppingCart.Models;

public class ApplicationDBContext: DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
    {
    }
    
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
}
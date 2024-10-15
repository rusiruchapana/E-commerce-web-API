using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCart.Models;

public class Order
{
    [Key]
    public int OrderId { get; set; }
    
    [ForeignKey("User")]
    public int UserId { get; set; }
    
    public User User { get; set; }
    
    public List<OrderDetail> OrderDetails { get; set; }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCart.Models;

public class OrderDetail
{
    [Key]
    public int OrderDetailId { get; set; }
    
    [ForeignKey("Order")]
    public int OrderId { get; set; }
    
    public Order Order { get; set; }
    
    [Required]
    public int ProductId { get; set; }
    
    public Product Product { get; set; }
    
    [Required]
    public int Quantity { get; set; }
}
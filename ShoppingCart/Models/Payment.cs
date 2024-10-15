using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Models;

public class Payment
{
    [Key]
    public int PaymentId { get; set; }
    
    [Required]
    public double Amount { get; set; }
    
    [Required]
    public int OrderId { get; set; }
    
    
    public Order Order { get; set; }
}
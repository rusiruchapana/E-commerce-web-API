using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Models;

public class User
{
    [Key]
    public int UserId { get; set; }
    
    [Required]
    public string UserName { get; set; }
    
    public List<Order> Orders { get; set; }
}
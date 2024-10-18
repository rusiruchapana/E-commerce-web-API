using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCart.Models;

public class Product
{
    [Key]
    public int ProductId { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public  double Price{ get; set; }
    
    [ForeignKey("Category")]
    public int CategoryId { get; set; }
    
    
    public Category Category { get; set; }
}
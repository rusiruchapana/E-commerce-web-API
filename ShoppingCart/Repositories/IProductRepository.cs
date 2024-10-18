using ShoppingCart.Models;

namespace ShoppingCart.Repositories;

public interface IProductRepository
{
    Task<Product> AddProduct(Product product);
    Task<IEnumerable<Product>> GetAllProducts();
}
using ShoppingCart.Models;

namespace ShoppingCart.Repositories;

public interface IProductRepository
{
    Task<Product> AddProduct(Product product);
    Task<IEnumerable<Product>> GetAllProducts();
    Task<Product> GetProductById(int id);

    Task<Product> UpdateProduct(Product product);
}
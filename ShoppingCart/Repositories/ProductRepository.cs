using Microsoft.EntityFrameworkCore;
using ShoppingCart.Models;

namespace ShoppingCart.Repositories;

public class ProductRepository: IProductRepository
{
    //DI
    private readonly ApplicationDBContext _applicationDbContext;

    public ProductRepository(ApplicationDBContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }


    public async Task<Product> AddProduct(Product product)
    {
        _applicationDbContext.Products.Add(product);
        await _applicationDbContext.SaveChangesAsync();
        return product;
    }

    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        return await _applicationDbContext.Products.ToListAsync();
    }
}
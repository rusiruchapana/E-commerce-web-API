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

    public async Task<Product> GetProductById(int id)
    {
        return await _applicationDbContext.Products.FindAsync(id);
    }

    public async Task<Product> UpdateProduct(Product product)
    {
        var existingProduct = await _applicationDbContext.Products.FindAsync(product.ProductId);
        existingProduct.Name = product.Name;
        existingProduct.Price = product.Price;
        existingProduct.CategoryId = product.CategoryId;
        existingProduct.Category = product.Category;

        await _applicationDbContext.SaveChangesAsync();
        return existingProduct;
    }

    public async Task<bool> DeleteProduct(int id)
    {
        var product = await _applicationDbContext.Products.FindAsync(id);
        
        if (product == null)
        {
            return false;
        }
       
        _applicationDbContext.Products.Remove(product);
        await _applicationDbContext.SaveChangesAsync();
        return true;
    }
}
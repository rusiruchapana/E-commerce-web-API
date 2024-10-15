using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Repositories;

namespace ShoppingCart.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController: ControllerBase
{
    //DI
    private readonly IProductRepository _productRepository;

    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    
    
}
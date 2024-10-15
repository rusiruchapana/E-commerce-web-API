using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Models;
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
    
    //POST method
    [HttpPost]
    public async Task<IActionResult> AddProduct(Product product)
    {
        var newProduct = await _productRepository.AddProduct(product);
        return Ok(newProduct);
    }







}
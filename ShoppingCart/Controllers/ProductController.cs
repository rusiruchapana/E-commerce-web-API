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
    public async Task<ActionResult> AddProduct(Product product)
    {
        var newProduct = await _productRepository.AddProduct(product);
        return Ok(newProduct);
    }

    //GET method
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()
    {
        var allProducts =  await  _productRepository.GetAllProducts();
        return Ok(allProducts);
    }

    //GET by ID
    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetProductById(int id)
    {
        var product = await _productRepository.GetProductById(id);
        if (product == null)
        {
            throw new Exception("product not found");
        }
        return product;
    }

    //UPDATE
    [HttpPut("{id}")]
    public async Task<ActionResult<Product>> UpdateProduct(int id , Product product)
    {
        if (id!=product.ProductId)
            return BadRequest();
        
        var updatedProduct = await _productRepository.UpdateProduct(product);
        
        if (updatedProduct == null)
            return NotFound();
        
        return Ok(updatedProduct);
    }
    
    //DELETE 
    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteProduct(int id)
    {
        var check = await _productRepository.DeleteProduct(id);
        if (check)
        {
            return NoContent();
        }
        
        return NotFound();
        
    }




}
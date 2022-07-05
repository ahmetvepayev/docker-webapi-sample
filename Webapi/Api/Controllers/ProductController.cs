using DockerWebApiTest.Data;
using DockerWebApiTest.Service;
using Microsoft.AspNetCore.Mvc;

namespace DockerWebApiTest.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_productService.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok(_productService.GetById(id));
    }

    [HttpPost]
    public IActionResult Add(Product product)
    {
        _productService.Add(product);
        return Ok();
    }

    [HttpPut]
    public IActionResult Update(Product product)
    {
        _productService.Update(product);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _productService.Delete(id);
        return Ok();
    }
}

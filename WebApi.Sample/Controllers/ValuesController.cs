using Microsoft.AspNetCore.Mvc;

namespace WebApi.Sample.Controllers;

//[Route("api/[controller]/[action]")]
[Route("api/Values/[action]")]
[ApiController]
public sealed class ValuesController : ControllerBase
{
    [HttpGet]
    public int Calculate()
    {
        return 5 + 4;
    }

    [HttpGet]
    public IActionResult Hello()
    {
        return Ok(new {Message = "Hello world" });
    }

    [HttpGet]
    public IActionResult Hello2()
    {
        return StatusCode(200,new { Message = "Hello world" });
    }

    [HttpGet]
    public IActionResult Hello3(int x, int y)
    {
        return StatusCode(200, new { Message = (x + y) * 10 });
    }


    [HttpPost]
    public IActionResult Hello4(Product request)
    {
        return StatusCode(200, new { Message = "Hello world" });
    }

    [HttpPost]
    public IActionResult Hello5(ProductDto request)
    {
        return StatusCode(200, new { Message = "Hello world" });
    }
}

public class Product
{
    public string Name { get; set; } = string.Empty;
}

public class Category
{
    public string Name { get; set; } = string.Empty;
}

public class ProductDto
{
    public Product Product { get; set; }
    public Category Category { get; set; }
}

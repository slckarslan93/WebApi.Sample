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
}

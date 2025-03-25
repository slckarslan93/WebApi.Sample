using Microsoft.AspNetCore.Mvc;

namespace WebApi.Sample.Controllers;

[Route("api/Values")]
[ApiController]
public sealed class ValuesController : ControllerBase
{
    [HttpGet("Calculate")]
    public int Calculate()
    {
        return 5 + 4;
    }
}

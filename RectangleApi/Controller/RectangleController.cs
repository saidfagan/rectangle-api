using Microsoft.AspNetCore.Mvc;

namespace RectangleApi.Controller;

[ApiController]
[Route("[controller]")]
public class RectangleController : ControllerBase
{
    [HttpGet("search")]
    public IActionResult Search() => Ok();
}
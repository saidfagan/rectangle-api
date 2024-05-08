using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RectangleApi.Data;
using RectangleApi.Model;

namespace RectangleApi.Controller;

[ApiController]
[Route("[controller]")]
public class RectangleController(RectangleContext context, IMapper mapper) : ControllerBase
{
    [HttpGet("search")]
    public ActionResult<List<RectangleDto>> Search(double x1, double y1, double x2, double y2)
    {
        var entities = context.Rectangles
            .Where(r => (r.X <= x1 && r.X + r.Width >= x2) || 
                        (r.Y <= y1 && r.Y + r.Height >= y2))
            .ToList();
        var dtos = mapper.Map<List<RectangleDto>>(entities);
        return Ok(dtos);
    }
}
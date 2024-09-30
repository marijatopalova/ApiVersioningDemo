using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningDemo.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(new { Message = "Products V1" });
    }
}

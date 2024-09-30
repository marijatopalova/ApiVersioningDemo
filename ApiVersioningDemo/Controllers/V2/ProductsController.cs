using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningDemo.Controllers.V2
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(new { Message = "Products V2" });
    }
}




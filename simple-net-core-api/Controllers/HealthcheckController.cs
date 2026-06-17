using Microsoft.AspNetCore.Mvc;

namespace simple_net_core_api.Controllers
{
    [Route("[controller]")]
    public class HealthcheckController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Status = "Healthy", Version = "1.0.0" });
        }
    }
}
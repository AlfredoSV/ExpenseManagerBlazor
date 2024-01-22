using ExpenseManagerBlazor.Shared;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseManagerBlazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpenseController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}

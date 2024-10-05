using Microsoft.AspNetCore.Mvc;

namespace OST_CORE_QA_API_2.Controllers
{
    [Route("api/[Controller]")]
    public class AuthenticationController : Controller
    {
        [HttpGet("GenServiceToken")]
        public IActionResult GenServiceToken()
        {
            return Ok(ServiceToken.GenerateServiceToken());
        }
    }
}

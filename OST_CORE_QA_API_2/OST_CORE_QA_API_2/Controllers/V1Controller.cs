using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace OST_CORE_QA_API_2.Controllers
{
    [Route("api/[controller]")]
    public class V1Controller : Controller
    {
        [EnableCors("AnotherPolicy")]
        [HttpGet("QryOutData")]
        public IActionResult QryOutData([Required] int i)
        {
            try
            {
                int abc = Convert.ToInt16("32 years"); 
            }
            catch (Exception ex)
            {
                //ErrorLog.SaveErrorLog("GlobalSection", exception.ToString());
            }
            return Ok("Now i am in AnotherPolicy");
        }
        [EnableCors("Policy1")]
        [HttpGet("QryOutDataSpecificPolicy")]
        public IActionResult QryOutDataSpecificPolicy([Required] int i)
        {
            return Ok("Now i am in Policy1");
        }
        [HttpPost("PostOutData")]
        public IActionResult PostOutData([FromBody] WeatherForecast weatherForecast)
        {
            return Ok("test data from text controller");
        }
    }
}

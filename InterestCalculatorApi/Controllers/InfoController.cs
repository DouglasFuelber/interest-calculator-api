using Microsoft.AspNetCore.Mvc;

namespace InterestCalculatorApi.Controllers
{
    [ApiController]
    [Route("showmethecode")]
    public class InfoController : Controller
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("https://github.com/DouglasFuelber/interest-calculator-api");
        }
    }
}
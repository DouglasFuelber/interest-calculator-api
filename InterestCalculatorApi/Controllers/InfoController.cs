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
            return NotFound();
        }
    }
}
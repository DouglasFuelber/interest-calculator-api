using Microsoft.AspNetCore.Mvc;

namespace InterestCalculatorApi.Controllers
{
    [ApiController]
    [Route("calculajuros")]
    public class InterestCalculatorController : ControllerBase
    {
        [HttpGet]
        public ActionResult<double> Get()
        {
            return NotFound();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace InterestCalculatorApi.Controllers
{
    [ApiController]
    [Route("calculajuros")]
    public class InterestCalculatorController : ControllerBase
    {
        [HttpGet]
        public ActionResult<double> Get(double valorinicial, int meses)
        {
            return Ok(0);
        }
    }
}

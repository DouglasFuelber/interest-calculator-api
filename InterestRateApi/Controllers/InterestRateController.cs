using Microsoft.AspNetCore.Mvc;

namespace InterestRateApi.Controllers
{
    [ApiController]
    [Route("taxajuros")]
    public class InterestRateController : ControllerBase
    {
        [HttpGet]
        public ActionResult<double> Get()
        {
            return Ok(0.01);
        }
    }
}

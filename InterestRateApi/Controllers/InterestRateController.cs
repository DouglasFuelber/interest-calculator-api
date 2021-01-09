using Microsoft.AspNetCore.Mvc;

namespace InterestRateApi.Controllers
{
    [ApiController]
    [Route("taxajuros")]
    public class InterestRateController : ControllerBase
    {
        [HttpGet]
        public double Get()
        {
            return 0.01;
        }
    }
}

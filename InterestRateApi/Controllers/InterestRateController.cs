using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace InterestRateApi.Controllers
{
    [ApiController]
    [Route("taxajuros")]
    public class InterestRateController : ControllerBase
    {

        private readonly ILogger<InterestRateController> _logger;

        public InterestRateController(ILogger<InterestRateController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public double Get()
        {
            return 0.01;
        }
    }
}

using InterestRateApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace InterestRateApi.Controllers
{
    [ApiController]
    [Route("taxajuros")]
    public class InterestRateController : ControllerBase
    {
        private readonly IInterestRateService _service;

        public InterestRateController(IInterestRateService service)
        {
            _service = service;
        }

        [HttpGet]
        public double Get()
        {
            return _service.GetInterestRate();
        }
    }
}

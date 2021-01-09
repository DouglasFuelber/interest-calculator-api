using InterestCalculatorApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace InterestCalculatorApi.Controllers
{
    [ApiController]
    [Route("calculajuros")]
    public class InterestCalculatorController : ControllerBase
    {
        private IInterestCalculatorService _service;
        public InterestCalculatorController(IInterestCalculatorService service) {
            _service = service;
        }

        [HttpGet]
        public ActionResult<double> Get(double valorInicial, int meses)
        {
            double taxaJuros = _service.GetInterestRate();

            double result = valorInicial * Math.Pow((1 + taxaJuros), meses);
            result = Math.Truncate(result * 100) / 100;

            return Ok(result);
        }
    }
}

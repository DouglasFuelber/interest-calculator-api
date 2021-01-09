using Microsoft.AspNetCore.Mvc;
using System;

namespace InterestCalculatorApi.Controllers
{
    [ApiController]
    [Route("calculajuros")]
    public class InterestCalculatorController : ControllerBase
    {
        [HttpGet]
        public ActionResult<double> Get(double valorInicial, int meses)
        {
            var result = valorInicial * Math.Pow((1 + 0.01), meses);
            result = Math.Truncate(result * 100) / 100;

            return Ok(result);
        }
    }
}

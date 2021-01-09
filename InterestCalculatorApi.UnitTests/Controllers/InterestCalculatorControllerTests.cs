using InterestCalculatorApi.Controllers;
using InterestCalculatorApi.Services;
using InterestCalculatorApi.UnitTests.Services;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace InterestCalculatorApi.UnitTests.Controllers
{
    public class InterestCalculatorControllerTests
    {
        InterestCalculatorController _controller;
        IInterestCalculatorService _service;

        public InterestCalculatorControllerTests()
        {
            _service = new InterestCalculatorServiceFake();
            _controller = new InterestCalculatorController(_service);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            var getResult = _controller.Get(0, 0);
            Assert.IsType<OkObjectResult>(getResult.Result);
        }

        [Theory]
        [InlineData(100, 5, 105.10)]
        public void Get_WhenCalled_ReturnsInterestCalculated(double valorinicial, int meses, double jurosResultado)
        {
            var getResult = (OkObjectResult) _controller.Get(valorinicial, meses).Result;
            Assert.Equal(jurosResultado, getResult.Value);
        }
    }
}

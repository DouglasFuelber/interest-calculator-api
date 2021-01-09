using InterestCalculatorApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace InterestCalculatorApi.UnitTests.Controllers
{
    public class InterestCalculatorControllerTests
    {
        InterestCalculatorController _controller;

        public InterestCalculatorControllerTests()
        {
            _controller = new InterestCalculatorController();
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

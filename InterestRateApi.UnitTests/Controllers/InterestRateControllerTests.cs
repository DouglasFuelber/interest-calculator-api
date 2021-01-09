using InterestRateApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace InterestRateApi.UnitTests.Controllers
{
    public class InterestRateControllerTests
    {
        InterestRateController _controller;
        public InterestRateControllerTests()
        {
            _controller = new InterestRateController();
        }

        [Fact]
        public void Get_WhenCalled_ReturnsDouble()
        {
            var getResult = _controller.Get();
            Assert.IsType<OkObjectResult>(getResult.Result);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsInterestRate()
        {
            var getResult = (OkObjectResult) _controller.Get().Result;
            Assert.Equal(0.01, getResult.Value);
        }
    }
}

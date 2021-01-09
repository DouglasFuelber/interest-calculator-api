using InterestCalculatorApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace InterestCalculatorApi.UnitTests.Controllers
{
    public class InfoControllerTests
    {
        InfoController _controller;

        public InfoControllerTests()
        {
            _controller = new InfoController();
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            var getResult = _controller.Get();
            Assert.IsType<OkObjectResult>(getResult.Result);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsRepositoryUrl()
        {
            var getResult = _controller.Get();
            Assert.Equal("https://github.com/DouglasFuelber/interest-calculator-api", getResult.Value);
        }
    }
}
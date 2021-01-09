using InterestRateApi.Controllers;
using InterestRateApi.Services;
using Xunit;

namespace InterestRateApi.UnitTests.Controllers
{
    public class InterestRateControllerTests
    {
        InterestRateController _controller;
        IInterestRateService _service;
        public InterestRateControllerTests()
        {
            _service = new InterestRateService();
            _controller = new InterestRateController(_service);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsDouble()
        {
            var getResult = _controller.Get();
            Assert.IsType<double>(getResult);
        }
    }
}

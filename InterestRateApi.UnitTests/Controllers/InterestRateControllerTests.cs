using InterestRateApi.Controllers;
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
            Assert.IsType<double>(getResult);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsInterestRate()
        {
            var getResult = _controller.Get();
            Assert.Equal(0.01, getResult);
        }
    }
}

using InterestRateApi.Services;
using Xunit;

namespace InterestRateApi.UnitTests.Services
{
    public class InterestRateServiceTests
    {
        IInterestRateService _service;
        public InterestRateServiceTests()
        {
            _service = new InterestRateService();
        }

        [Fact]
        public void GetInterestRate_WhenCalled_ReturnsInterestRate()
        {
            var interestRate = _service.GetInterestRate();
            Assert.Equal(0.01, interestRate);
        }
    }
}

using InterestCalculatorApi.Services;

namespace InterestCalculatorApi.UnitTests.Services
{
    public class InterestCalculatorServiceFake : IInterestCalculatorService
    {
        public double GetInterestRate()
        {
            return 0.01;
        }
    }
}

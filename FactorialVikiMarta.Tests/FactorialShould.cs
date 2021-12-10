using Xunit;

namespace FactorialVikiMarta.Tests
{
    public class FactorialShould
    {
        [Fact]
        public void Return1WhenNumberIs0()
        {
            
            int actual = Factorial.Calculate(0);
            
            Assert.Equal(1, actual);
        }
    }
}

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

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        public void ReturnAFactorialOfTheGivenNumber(int number, int expected)
        {
            int actual = Factorial.Calculate(number);
            
            Assert.Equal(expected, actual);
        }

    }
}

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
        
        [Fact]
        public void Return1WhenNumberIs1()
        {
            
            int actual = Factorial.Calculate(1);
            
            Assert.Equal(1, actual);
        }
        
        [Fact]
        public void Return2WhenNumberIs2()
        {
            
            int actual = Factorial.Calculate(2);
            
            Assert.Equal(2, actual);
        }

        [Fact]
        public void Return6WhenNumberIs3()
        {
            
            int actual = Factorial.Calculate(3);
            
            Assert.Equal(6, actual);
        }

    }
}

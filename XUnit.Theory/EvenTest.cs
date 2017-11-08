using Xunit;

namespace XUnit.Theory
{
    public class EvenTest
    {
        [Theory]
        [InlineData(42, true)]
        [InlineData(43, false)]
        public void TestEven(int number, bool expected)
        {
            var even = new Even();
            Assert.Equal(even.Determine(number), expected);
        }
    }
}
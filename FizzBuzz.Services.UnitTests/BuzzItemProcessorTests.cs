using FizzBuzz.Services.Interfaces;
using FizzBuzz.Services.ItemProcessors;
using Xunit;

namespace FizzBuzz.Services.UnitTests
{
    public class BuzzItemProcessorTests
    {
        private readonly IItemProcessor _itemProcessor;
        public BuzzItemProcessorTests() 
        {
            _itemProcessor = new BuzzItemProcessor();
        }

        [Fact]
        public void BuzzItemProcess_Returns_Buzz_Result()
        {
            var input = "5";
            var result = _itemProcessor.ProcessInputItem(input);

            Assert.Equal("Buzz", result.Result);
        }
    }
}

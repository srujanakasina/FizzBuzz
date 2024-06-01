using FizzBuzz.Services.Interfaces;
using FizzBuzz.Services.ItemProcessors;
using Xunit;

namespace FizzBuzz.Services.UnitTests
{
    public class FizzBuzzItemProcessorTests
    {
        private readonly IItemProcessor _itemProcessor;
        public FizzBuzzItemProcessorTests() 
        {
            _itemProcessor = new FizzBuzzItemProcessor();
        }

        [Fact]
        public void FizzBuzzItemProcess_Returns_FizzBuzz_Result()
        {
            var input = "15";
            var result = _itemProcessor.ProcessInputItem(input);

            Assert.Equal("FizzBuzz", result.Result);
        }
    }
}

using FizzBuzz.Services.Interfaces;
using FizzBuzz.Services.ItemProcessors;
using Xunit;

namespace FizzBuzz.Services.UnitTests
{
    public class FizzItemProcessorTests
    {
        private readonly IItemProcessor _itemProcessor;
        public FizzItemProcessorTests() 
        {
            _itemProcessor = new FizzItemProcessor();
        }

        [Fact]
        public void FizzItemProcess_Returns_Fizz_Result()
        {
            var input = "3";
            var result = _itemProcessor.ProcessInputItem(input);

            Assert.Equal("Fizz", result.Result);
        }
    }
}

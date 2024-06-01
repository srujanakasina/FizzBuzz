using FizzBuzz.Services.Interfaces;
using FizzBuzz.Services.ItemProcessors;
using Xunit;

namespace FizzBuzz.Services.UnitTests
{
    public class InvalidItemProcessorTests
    {
        private readonly IItemProcessor _itemProcessor;
        public InvalidItemProcessorTests() 
        {
            _itemProcessor = new InvalidItemProcessor();
        }

        [Fact]
        public void InvalidItemProcess_Returns_Invalid_Item_Result()
        {
            var input = "A";
            var result = _itemProcessor.ProcessInputItem(input);

            Assert.Equal("Invalid item", result.Result);
        }
    }
}

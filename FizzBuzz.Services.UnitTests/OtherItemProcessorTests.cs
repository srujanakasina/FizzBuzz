using FizzBuzz.Services.Interfaces;
using FizzBuzz.Services.ItemProcessors;
using Xunit;

namespace FizzBuzz.Services.UnitTests
{
    public class OtherItemProcessorTests
    {
        private readonly IItemProcessor _itemProcessor;
        public OtherItemProcessorTests() 
        {
            _itemProcessor = new OtherNumberItemProcessor();
        }

        [Fact]
        public void OtherItemProcess_Returns_Invalid_Item_Result()
        {
            var input = "1";
            var result = _itemProcessor.ProcessInputItem(input);

            Assert.Equal("Divided 1 by 3 Divided 1 by 5", result.Result);
        }
    }
}

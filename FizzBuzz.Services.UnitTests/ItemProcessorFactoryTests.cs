using FizzBuzz.Services.Interfaces;
using FizzBuzz.Services.ItemProcessors;
using Xunit;

namespace FizzBuzz.Services.UnitTests
{
    public class ItemProcessorFactoryTests
    {
        [Fact]
        public void CreateItemProcessor_Returns_FizzItemProcessor_When_Divisible_By_3()
        {
            string input = "3";

            var inputProcessor = ItemProcessFactory.CreateItemProcessor(input);

            Assert.IsType<FizzItemProcessor>(inputProcessor);
        }

        [Fact]
        public void CreateItemProcessor_Returns_BuzzItemProcessor_When_Divisible_By_5()
        {
            string input = "5";

            var inputProcessor = ItemProcessFactory.CreateItemProcessor(input);

            Assert.IsType<BuzzItemProcessor>(inputProcessor);
        }

        [Fact]
        public void CreateItemProcessor_Returns_FizzBuzzItemProcessor_When_Divisible_By_15()
        {
            string input = "15";

            var inputProcessor = ItemProcessFactory.CreateItemProcessor(input);

            Assert.IsType<FizzBuzzItemProcessor>(inputProcessor);
        }

        [Fact]
        public void CreateItemProcessor_Returns_InvalidItemProcessor_When_Item_Is_A_String()
        {
            string input = "A";

            var inputProcessor = ItemProcessFactory.CreateItemProcessor(input);

            Assert.IsType<InvalidItemProcessor>(inputProcessor);
        }

        [Fact]
        public void CreateItemProcessor_Returns_OtherNumberItemProcessor_When_Item_Is_Not_3_Or_5()
        {
            string input = "1";

            var inputProcessor = ItemProcessFactory.CreateItemProcessor(input);

            Assert.IsType<OtherNumberItemProcessor>(inputProcessor);
        }
    }
}

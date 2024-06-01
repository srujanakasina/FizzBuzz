using FizzBuzz.Services.Interfaces;
using Moq;
using Xunit;

namespace FizzBuzz.Services.UnitTests
{
    public class InputProcessorTests
    {
        private readonly InputProcessor _processor;

        public InputProcessorTests() 
        {
            _processor = new InputProcessor();
        }

        [Fact]
        public void InputProcessor_Output_Length_Matches_Input_Length()
        {
            // Arrange
            var inputs = new string[] {"1",  "2", "3", "A", "NAN", "5", "15"};

            //Act
            var output = _processor.ProcessInputs(inputs);

            //Assert
            Assert.Equal(output.Count(), inputs.Length);
        }
    }
}

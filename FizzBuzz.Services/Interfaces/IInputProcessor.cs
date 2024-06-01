using FizzBuzz.Models;

namespace FizzBuzz.Services.Interfaces
{
    public interface IInputProcessor
    {
        public IEnumerable<FizzBuzzModel> ProcessInputs(string[] input);
    }
}

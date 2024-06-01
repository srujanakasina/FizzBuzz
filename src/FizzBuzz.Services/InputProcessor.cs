using FizzBuzz.Models;
using FizzBuzz.Services.Interfaces;

namespace FizzBuzz.Services
{
    public class InputProcessor : IInputProcessor
    {
        public InputProcessor()
        {
        }
        public IEnumerable<FizzBuzzModel> ProcessInputs(string[] input)
        {
            var items = new List<FizzBuzzModel>();
            for (int i = 0; i < input.Length; i++)
            {
                var itemProcessor = ItemProcessFactory.CreateItemProcessor(input[i]);
                var fizzBuzzItem = itemProcessor.ProcessInputItem(input[i]);
                items.Add(fizzBuzzItem);
            }
            return items;
        }
    }
}

using FizzBuzz.Models;
using FizzBuzz.Services.Interfaces;

namespace FizzBuzz.Services.ItemProcessors
{
    internal class FizzBuzzItemProcessor : IItemProcessor
    {
        public FizzBuzzModel ProcessInputItem(string inputItem)
        {
            return new FizzBuzzModel { Input = inputItem, Result = "FizzBuzz" };
        }
    }
}

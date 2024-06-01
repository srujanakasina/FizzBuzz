using FizzBuzz.Models;

namespace FizzBuzz.Services.Interfaces
{
    internal interface IItemProcessor
    {
        public FizzBuzzModel ProcessInputItem(string inputItem);
    }
}

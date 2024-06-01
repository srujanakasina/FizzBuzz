using FizzBuzz.Services.Interfaces;
using FizzBuzz.Services.ItemProcessors;

namespace FizzBuzz.Services
{
    internal class ItemProcessFactory
    {
        public static IItemProcessor CreateItemProcessor(string input)
        {
            if (int.TryParse(input, out var quantity))
            {
                if (quantity % 3 == 0 && quantity % 5 == 0)
                {
                    return new FizzBuzzItemProcessor();
                }
                else if (quantity % 3 == 0)
                {
                    return new FizzItemProcessor();
                }
                else if (quantity % 5 == 0)
                {
                    return new BuzzItemProcessor();
                }
                else
                {
                    return new OtherNumberItemProcessor();
                }
            }
            else
            {
                return new InvalidItemProcessor();
            }
        }
    }
}

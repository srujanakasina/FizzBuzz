using FizzBuzz.Models;
using FizzBuzz.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Services.ItemProcessors
{
    internal class FizzItemProcessor : IItemProcessor
    {
        public FizzBuzzModel ProcessInputItem(string inputItem)
        {
            return new FizzBuzzModel() { Input = inputItem, Result = "Fizz" };
        }
    }
}

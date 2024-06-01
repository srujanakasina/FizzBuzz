using FizzBuzz.Models;
using FizzBuzz.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Services.ItemProcessors
{
    internal class OtherNumberItemProcessor : IItemProcessor
    {
        public FizzBuzzModel ProcessInputItem(string inputItem)
        {
            return new FizzBuzzModel { Input = inputItem, Result = $"Divided {inputItem} by 3 Divided {inputItem} by 5" };
        }
    }
}

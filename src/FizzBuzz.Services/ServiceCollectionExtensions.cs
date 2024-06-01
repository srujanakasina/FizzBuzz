using FizzBuzz.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace FizzBuzz.Services
{
    public static class ServiceCollectionExtensions
    {
        public static void AddFizzBizzServices(this IServiceCollection services)
        {
            services.AddTransient<IInputProcessor, InputProcessor>();
        }
    }
}

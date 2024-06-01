using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.IntegrationTests
{
    public class HttpServerFixture<T> : WebApplicationFactory<T>
        where T : class
    {
        public readonly HttpClient ClientFactory;
        public HttpServerFixture() : base() 
        {
            ClientFactory = CreateClient();
        }

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {

            });
        }
    }
}

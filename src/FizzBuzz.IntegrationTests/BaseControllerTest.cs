using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.IntegrationTests
{
    public class BaseControllerTest : IClassFixture<HttpServerFixture<Program>>
    {
        public HttpServerFixture<Program> Fixture { get; }
        public HttpClient Client() => Fixture.ClientFactory;
        
        public BaseControllerTest(HttpServerFixture<Program> fixture) 
        {
            Fixture = fixture;
        }
    }
}

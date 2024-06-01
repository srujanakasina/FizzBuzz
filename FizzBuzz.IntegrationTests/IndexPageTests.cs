using AngleSharp;
using AngleSharp.Html.Dom;
using AngleSharp.Io;
using FizzBuzz.IntegrationTests.Helpers;
using System.Net.Http.Headers;

namespace FizzBuzz.IntegrationTests
{
    public class IndexPageTests : BaseControllerTest
    {
        public IndexPageTests(HttpServerFixture<Program> fixture) : base(fixture)
        {
        }

        [Fact]
        public async void Index_Page_Returns_200()
        {
            var client = this.Fixture.CreateClient();

            var response = await client.GetAsync("/");

            response.EnsureSuccessStatusCode();

            var indexPage = await HtmlHelpers.GetDocumentAsync(response);
            var header = indexPage.QuerySelector("#page-header");
            Assert.Equal("FizzBuzz Results", header?.TextContent);
        }
    }
}

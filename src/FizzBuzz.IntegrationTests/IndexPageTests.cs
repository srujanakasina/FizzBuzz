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

        [Fact]
        public async void Index_Page_Results_Match_Expected_Values()
        {
            var expectedArray = new string[] { "Divided 1 by 3 Divided 1 by 5", "Fizz", "Buzz", "Invalid item", "FizzBuzz", "Invalid item", "Divided 23 by 3 Divided 23 by 5" };
            var client = this.Fixture.CreateClient();

            var response = await client.GetAsync("/");

            response.EnsureSuccessStatusCode();

            var indexPage = await HtmlHelpers.GetDocumentAsync(response);
            var results = indexPage.QuerySelectorAll("body > div > main > div > table > tbody > tr > td:nth-child(2)");
            Assert.Equal(7, results.Length);
            Assert.Equal(expectedArray, results.Select(r => r.TextContent).ToArray());
        }
    }
}

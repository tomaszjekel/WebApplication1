using FluentAssertions;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Threading.Tasks;
using WebApplication1;
using Xunit;

namespace XUnitTestProject1
{
    public class HomeControllerTests
    {
        [Fact]
        public async Task Get_index_test_should_return_html()
        {
            var server = new TestServer(WebHost.CreateDefaultBuilder().UseStartup<Startup>());
            var httpClient = server.CreateClient();

            var response = await httpClient.GetAsync("/Home/Test");
            response.IsSuccessStatusCode.Should().BeTrue();
        }
    }
}
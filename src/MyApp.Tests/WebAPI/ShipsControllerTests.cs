using System.Net;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;

public class ShipsControllerTests : IClassFixture<WebApplicationFactory<Program>> {
  private readonly WebApplicationFactory<Program> _factory;
  public ShipsControllerTests(WebApplicationFactory<Program> factory) {
    _factory = factory;
  }

  [Fact]
  public async Task GetAll_ReturnsOK() {
    var client = _factory.CreateClient();
    var resp = await client.GetAsync("/api/ships");
    Assert.Equal(HttpStatusCode.OK, resp.StatusCode);
  }
}
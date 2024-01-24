using Shouldly;

namespace JetSolution.Tests.Api.HelloWorld;

public class WhenCallRootEndpoint(TestWebApplicationFactory factory) : TestBase(factory)
{
    [Fact]
    public async Task ShouldReturnHelloWorld()
    {
        // Arrange
        // Act
        
        var response = await Client.GetAsync("/");
        
        // Assert
        
        response.IsSuccessStatusCode.ShouldBeTrue();
        var content = await response.Content.ReadAsStringAsync();
        
        content.ShouldBe("Hello World!");
    }
}
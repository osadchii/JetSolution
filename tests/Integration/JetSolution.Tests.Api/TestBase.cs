namespace JetSolution.Tests.Api;

public abstract class TestBase(TestWebApplicationFactory factory) : IClassFixture<TestWebApplicationFactory>
{
    protected readonly HttpClient Client = factory.CreateClient();
}
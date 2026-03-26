namespace Meshcapade.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static MeshcapadeClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("MESHCAPADE_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("MESHCAPADE_API_KEY environment variable is not found.");

        var client = new MeshcapadeClient(apiKey);
        
        return client;
    }
}

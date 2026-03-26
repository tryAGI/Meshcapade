/*
order: 30
title: Search Motions
slug: search-motions

Shows how to search for motions by text description.
*/

namespace Meshcapade.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task SearchMotions()
    {
        using var client = GetAuthenticatedClient();

        //// Search for motions matching a text description.
        var response = await client.Motions.SearchMotionsAsync(new SearchMotionsRequest
        {
            Text = "walking forward",
            NumMotions = 5,
        });
        response.Data.Should().NotBeNull();
        Console.WriteLine($"Found {response.Data!.Count} motions");
    }
}

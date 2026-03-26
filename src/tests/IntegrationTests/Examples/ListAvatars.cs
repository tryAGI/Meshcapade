/*
order: 20
title: List Avatars
slug: list-avatars

Shows how to list existing avatars.
*/

namespace Meshcapade.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListAvatars()
    {
        using var client = GetAuthenticatedClient();

        //// List all avatars for the authenticated user.
        var response = await client.Avatars.ListAvatarsAsync(
            limit: 10,
            page: 1);
        response.Data.Should().NotBeNull();
        Console.WriteLine($"Found {response.Data!.Count} avatars");
    }
}

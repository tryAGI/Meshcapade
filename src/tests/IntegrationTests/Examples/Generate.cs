/*
order: 10
title: Avatar from Measurements
slug: avatar-from-measurements

Shows how to create an avatar from body measurements.
*/

namespace Meshcapade.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task AvatarFromMeasurements()
    {
        using var client = GetAuthenticatedClient();

        //// Create an avatar from body measurements.
        var response = await client.AvatarsFromMeasurements.CreateAvatarFromMeasurementsAsync(
            new MeasurementAvatarRequest
            {
                Gender = Gender.Male,
                Name = "test-avatar",
                ModelVersion = ModelVersion.Smplx,
            });
        response.Data.Should().NotBeNull();
        response.Data!.Id.Should().NotBeNull();
        Console.WriteLine($"Avatar ID: {response.Data.Id}");
    }
}

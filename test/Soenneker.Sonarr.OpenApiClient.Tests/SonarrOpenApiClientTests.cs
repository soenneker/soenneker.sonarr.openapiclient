using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Sonarr.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class SonarrOpenApiClientTests : FixturedUnitTest
{
    public SonarrOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}

using Soenneker.Tests.HostedUnit;

namespace Soenneker.Sonarr.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class SonarrOpenApiClientTests : HostedUnitTest
{
    public SonarrOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}

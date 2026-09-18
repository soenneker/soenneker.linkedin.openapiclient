using Soenneker.Tests.HostedUnit;

namespace Soenneker.LinkedIn.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class LinkedInOpenApiClientTests : HostedUnitTest
{
    public LinkedInOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}

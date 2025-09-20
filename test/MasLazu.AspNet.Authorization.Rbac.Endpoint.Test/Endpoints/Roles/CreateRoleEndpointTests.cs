using Xunit;
using MasLazu.AspNet.Authorization.Rbac.Endpoint.Endpoints.Roles;

namespace MasLazu.AspNet.Authorization.Rbac.Endpoint.Test.Endpoints.Roles;

public class CreateRoleEndpointTests
{
    [Fact]
    public void CreateRoleEndpoint_InheritsFromBaseEndpoint()
    {
        var endpoint = new CreateRoleEndpoint();

        Assert.NotNull(endpoint);
        Assert.IsType<CreateRoleEndpoint>(endpoint);
    }
}

using Xunit;
using MasLazu.AspNet.Authorization.Rbac.Endpoint.Endpoints.Roles;

namespace MasLazu.AspNet.Authorization.Rbac.Endpoint.Test.Endpoints.Roles;

public class GetRoleByIdEndpointTests
{
    [Fact]
    public void GetRoleByIdEndpoint_InheritsFromBaseEndpoint()
    {
        var endpoint = new GetRoleByIdEndpoint();

        Assert.NotNull(endpoint);
        Assert.IsType<GetRoleByIdEndpoint>(endpoint);
    }
}

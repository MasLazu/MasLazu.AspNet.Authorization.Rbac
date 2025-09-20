using Xunit;
using MasLazu.AspNet.Authorization.Rbac.Endpoint.EndpointGroups;

namespace MasLazu.AspNet.Authorization.Rbac.Endpoint.Test.EndpointGroups;

public class RolesEndpointGroupTests
{
    [Fact]
    public void RolesEndpointGroup_InheritsFromSubGroup()
    {
        var group = new RolesEndpointGroup();

        Assert.NotNull(group);
        Assert.IsType<RolesEndpointGroup>(group);
    }
}

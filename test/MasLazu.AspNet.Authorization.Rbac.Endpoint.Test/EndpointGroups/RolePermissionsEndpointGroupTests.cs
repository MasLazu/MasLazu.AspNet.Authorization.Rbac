using Xunit;
using MasLazu.AspNet.Authorization.Rbac.Endpoint.EndpointGroups;

namespace MasLazu.AspNet.Authorization.Rbac.Endpoint.Test.EndpointGroups;

public class RolePermissionsEndpointGroupTests
{
    [Fact]
    public void RolePermissionsEndpointGroup_InheritsFromSubGroup()
    {
        var group = new RolePermissionsEndpointGroup();

        Assert.NotNull(group);
        Assert.IsType<RolePermissionsEndpointGroup>(group);
    }
}

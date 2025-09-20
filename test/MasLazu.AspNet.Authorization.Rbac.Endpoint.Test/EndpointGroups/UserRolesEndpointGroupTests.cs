using Xunit;
using MasLazu.AspNet.Authorization.Rbac.Endpoint.EndpointGroups;

namespace MasLazu.AspNet.Authorization.Rbac.Endpoint.Test.EndpointGroups;

public class UserRolesEndpointGroupTests
{
    [Fact]
    public void UserRolesEndpointGroup_InheritsFromSubGroup()
    {
        var group = new UserRolesEndpointGroup();

        Assert.NotNull(group);
        Assert.IsType<UserRolesEndpointGroup>(group);
    }
}

using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;
using Xunit;

namespace MasLazu.AspNet.Authorization.Rbac.Abstraction.Test.Models;

public class CreateRolePermissionRequestTests
{
    [Fact]
    public void CanCreateCreateRolePermissionRequest()
    {
        var permissionId = Guid.NewGuid();
        var roleId = Guid.NewGuid();

        var request = new CreateRolePermissionRequest(permissionId, roleId);

        Assert.Equal(permissionId, request.PermissionId);
        Assert.Equal(roleId, request.RoleId);
    }
}

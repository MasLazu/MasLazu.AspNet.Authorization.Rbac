using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;
using Xunit;

namespace MasLazu.AspNet.Authorization.Rbac.Abstraction.Test.Models;

public class UpdateRolePermissionRequestTests
{
    [Fact]
    public void CanCreateUpdateRolePermissionRequest()
    {
        var id = Guid.NewGuid();
        var permissionId = Guid.NewGuid();
        var roleId = Guid.NewGuid();

        var request = new UpdateRolePermissionRequest(id, permissionId, roleId);

        Assert.Equal(id, request.Id);
        Assert.Equal(permissionId, request.PermissionId);
        Assert.Equal(roleId, request.RoleId);
    }
}

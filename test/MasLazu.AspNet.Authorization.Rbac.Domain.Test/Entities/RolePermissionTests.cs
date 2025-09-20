using Xunit;
using MasLazu.AspNet.Authorization.Rbac.Domain.Entities;

namespace MasLazu.AspNet.Authorization.Rbac.Domain.Test.Entities;

public class RolePermissionTests
{
    [Fact]
    public void CanCreateRolePermission()
    {
        var permissionId = Guid.NewGuid();
        var roleId = Guid.NewGuid();

        var rolePermission = new RolePermission
        {
            PermissionId = permissionId,
            RoleId = roleId
        };

        Assert.Equal(permissionId, rolePermission.PermissionId);
        Assert.Equal(roleId, rolePermission.RoleId);
        Assert.Null(rolePermission.Role);
    }
}

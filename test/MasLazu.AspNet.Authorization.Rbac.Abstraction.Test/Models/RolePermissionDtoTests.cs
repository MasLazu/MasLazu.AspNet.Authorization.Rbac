using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;
using Xunit;

namespace MasLazu.AspNet.Authorization.Rbac.Abstraction.Test.Models;

public class RolePermissionDtoTests
{
    [Fact]
    public void CanCreateRolePermissionDto()
    {
        var id = Guid.NewGuid();
        var permissionId = Guid.NewGuid();
        var roleId = Guid.NewGuid();
        DateTimeOffset createdAt = DateTimeOffset.Now;
        DateTimeOffset updatedAt = DateTimeOffset.Now;

        var dto = new RolePermissionDto(id, permissionId, roleId, createdAt, updatedAt);

        Assert.Equal(id, dto.Id);
        Assert.Equal(permissionId, dto.PermissionId);
        Assert.Equal(roleId, dto.RoleId);
        Assert.Equal(createdAt, dto.CreatedAt);
        Assert.Equal(updatedAt, dto.UpdatedAt);
    }
}

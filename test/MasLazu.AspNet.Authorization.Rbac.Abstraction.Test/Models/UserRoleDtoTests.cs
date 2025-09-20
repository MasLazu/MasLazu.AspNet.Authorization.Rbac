using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;
using Xunit;

namespace MasLazu.AspNet.Authorization.Rbac.Abstraction.Test.Models;

public class UserRoleDtoTests
{
    [Fact]
    public void CanCreateUserRoleDto()
    {
        var id = Guid.NewGuid();
        var roleId = Guid.NewGuid();
        var userId = Guid.NewGuid();
        DateTimeOffset createdAt = DateTimeOffset.Now;
        DateTimeOffset updatedAt = DateTimeOffset.Now;

        var dto = new UserRoleDto(id, roleId, userId, createdAt, updatedAt);

        Assert.Equal(id, dto.Id);
        Assert.Equal(roleId, dto.RoleId);
        Assert.Equal(userId, dto.UserId);
        Assert.Equal(createdAt, dto.CreatedAt);
        Assert.Equal(updatedAt, dto.UpdatedAt);
    }
}

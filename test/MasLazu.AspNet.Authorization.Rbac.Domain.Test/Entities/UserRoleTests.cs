using Xunit;
using MasLazu.AspNet.Authorization.Rbac.Domain.Entities;

namespace MasLazu.AspNet.Authorization.Rbac.Domain.Test.Entities;

public class UserRoleTests
{
    [Fact]
    public void CanCreateUserRole()
    {
        var roleId = Guid.NewGuid();
        var userId = Guid.NewGuid();

        var userRole = new UserRole
        {
            RoleId = roleId,
            UserId = userId
        };

        Assert.Equal(roleId, userRole.RoleId);
        Assert.Equal(userId, userRole.UserId);
        Assert.Null(userRole.Role);
    }
}

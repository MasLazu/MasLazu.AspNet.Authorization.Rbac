using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;
using Xunit;

namespace MasLazu.AspNet.Authorization.Rbac.Abstraction.Test.Models;

public class CreateUserRoleRequestTests
{
    [Fact]
    public void CanCreateCreateUserRoleRequest()
    {
        var roleId = Guid.NewGuid();
        var userId = Guid.NewGuid();

        var request = new CreateUserRoleRequest(roleId, userId);

        Assert.Equal(roleId, request.RoleId);
        Assert.Equal(userId, request.UserId);
    }
}

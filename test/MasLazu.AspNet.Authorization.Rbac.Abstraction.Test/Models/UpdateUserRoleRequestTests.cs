using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;
using Xunit;

namespace MasLazu.AspNet.Authorization.Rbac.Abstraction.Test.Models;

public class UpdateUserRoleRequestTests
{
    [Fact]
    public void CanCreateUpdateUserRoleRequest()
    {
        var id = Guid.NewGuid();
        var roleId = Guid.NewGuid();
        var userId = Guid.NewGuid();

        var request = new UpdateUserRoleRequest(id, roleId, userId);

        Assert.Equal(id, request.Id);
        Assert.Equal(roleId, request.RoleId);
        Assert.Equal(userId, request.UserId);
    }
}

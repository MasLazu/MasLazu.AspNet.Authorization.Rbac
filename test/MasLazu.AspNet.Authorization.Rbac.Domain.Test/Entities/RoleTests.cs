using Xunit;
using MasLazu.AspNet.Authorization.Rbac.Domain.Entities;

namespace MasLazu.AspNet.Authorization.Rbac.Domain.Test.Entities;

public class RoleTests
{
    [Fact]
    public void CanCreateRole()
    {
        var role = new Role
        {
            Name = "Admin",
            Description = "Administrator role"
        };

        Assert.Equal("Admin", role.Name);
        Assert.Equal("Administrator role", role.Description);
    }
}

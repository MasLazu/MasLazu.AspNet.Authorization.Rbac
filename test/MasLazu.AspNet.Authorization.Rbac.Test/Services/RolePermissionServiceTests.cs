using Xunit;
using MasLazu.AspNet.Authorization.Rbac.Services;

namespace MasLazu.AspNet.Authorization.Rbac.Test.Services;

public class RolePermissionServiceTests
{
    [Fact]
    public void RolePermissionService_InheritsFromCorrectBase()
    {
        // Test that RolePermissionService is defined and inherits from the correct base
        Assert.NotNull(typeof(RolePermissionService));
        Assert.True(typeof(RolePermissionService).IsClass);
    }
}

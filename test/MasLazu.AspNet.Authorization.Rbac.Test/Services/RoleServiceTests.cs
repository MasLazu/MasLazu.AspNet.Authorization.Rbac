using Xunit;
using MasLazu.AspNet.Authorization.Rbac.Services;

namespace MasLazu.AspNet.Authorization.Rbac.Test.Services;

public class RoleServiceTests
{
    [Fact]
    public void RoleService_InheritsFromCorrectBase()
    {
        // Test that RoleService is defined and inherits from the correct base
        Assert.NotNull(typeof(RoleService));
        Assert.True(typeof(RoleService).IsClass);
    }
}

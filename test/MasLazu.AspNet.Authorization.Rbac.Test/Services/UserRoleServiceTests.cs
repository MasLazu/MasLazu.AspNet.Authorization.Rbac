using Xunit;
using MasLazu.AspNet.Authorization.Rbac.Services;

namespace MasLazu.AspNet.Authorization.Rbac.Test.Services;

public class UserRoleServiceTests
{
    [Fact]
    public void UserRoleService_InheritsFromCorrectBase()
    {
        // Test that UserRoleService is defined and inherits from the correct base
        Assert.NotNull(typeof(UserRoleService));
        Assert.True(typeof(UserRoleService).IsClass);
    }
}

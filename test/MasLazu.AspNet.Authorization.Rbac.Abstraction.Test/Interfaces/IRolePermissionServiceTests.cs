using MasLazu.AspNet.Authorization.Rbac.Abstraction.Interfaces;
using Xunit;

namespace MasLazu.AspNet.Authorization.Rbac.Abstraction.Test.Interfaces;

public class IRolePermissionServiceTests
{
    [Fact]
    public void InterfaceExists()
    {
        // Test that the interface is defined
        Assert.NotNull(typeof(IRolePermissionService));
    }
}

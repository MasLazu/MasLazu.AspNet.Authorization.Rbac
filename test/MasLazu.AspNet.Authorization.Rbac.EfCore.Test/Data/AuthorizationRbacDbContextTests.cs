using Xunit;
using MasLazu.AspNet.Authorization.Rbac.EfCore.Data;

namespace MasLazu.AspNet.Authorization.Rbac.EfCore.Test.Data;

public class AuthorizationRbacDbContextTests
{
    [Fact]
    public void AuthorizationRbacDbContext_InheritsFromBaseDbContext()
    {
        // Test that the context is defined
        Assert.NotNull(typeof(AuthorizationRbacDbContext));
        Assert.True(typeof(AuthorizationRbacDbContext).IsClass);
    }
}
